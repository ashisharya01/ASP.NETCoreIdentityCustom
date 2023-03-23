namespace ASP.NETCoreIdentityCustom.Controllers
{
    public interface IProductService
    {
        Task DeleteProduct(int productId);
        Task GetProductAsync();
    }
}