namespace StateContainers.Services;

public interface ICartService
{
    int GetItemCount();
    void AddItemToCart(Item item);
    event Action<int> OnItemAdded;
}

public record Item(int Id, string Name);
