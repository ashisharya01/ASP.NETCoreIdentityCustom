namespace ASP.NETCoreIdentityCustom.Models
{
    public class Products
    {
        public string? ProductName { get; set; }
        public string? ProductDescrption { get; set; }
        public string? ProductPrice { get; set; }
        public string? ProductStocks{  get; set; }

        public bool LogOut { get; set; }
    }
}
