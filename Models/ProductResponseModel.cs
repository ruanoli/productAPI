namespace ProductAPI.Services.Models
{
    /// <summary>
    /// Respostas para serviços POST, PUT e DELETE
    /// </summary>
    public class ProductResponseModel
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public ProductGetModel? Product { get; set; }
    }
}
