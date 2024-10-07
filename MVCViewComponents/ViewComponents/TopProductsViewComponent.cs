using Microsoft.AspNetCore.Mvc;
using MVCViewComponents.Services;

namespace MVCViewComponents.ViewComponents;

public class TopProductsViewComponent : ViewComponent
{
    private readonly IProductService _productService;

    public TopProductsViewComponent(IProductService productService)
    {
        _productService = productService;
    }

    public async Task<IViewComponentResult> InvokeAsync(int count)
    {
        var products = await _productService.GetTopProductsAsync(count);
        return View(products);
    }
}
