namespace StateContainers.Services;

public class CartService : ICartService
{
    private readonly IList<Item> _items = new List<Item>();
    public event Action<int>? OnItemAdded;

    public void AddItemToCart(Item item)
    {
        _items.Add(item);
        OnItemAdded?.Invoke(_items.Count);
    }

    public int GetItemCount()
    {
        return _items.Count;
    }
}
