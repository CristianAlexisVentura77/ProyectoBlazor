namespace SistemaVenta.ClientBlazor.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string Descripcion { get; set; }    
    }
}
