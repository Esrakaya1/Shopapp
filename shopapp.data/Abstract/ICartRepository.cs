using shopapp.entity;

namespace shopapp.data.Abstract
{
    public interface ICartRepository : IRepository<Cart>
    {
        void DeleteFromCart(int cartId, int productId);
        Cart GetByUserId(string userId);

        void ClearCart(int cartId);

    }
}
