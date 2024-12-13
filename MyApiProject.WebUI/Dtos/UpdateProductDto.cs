namespace MyApiProject.WebUI.Dtos
{
    public class UpdateProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductDecimal { get; set; }
    }
}
