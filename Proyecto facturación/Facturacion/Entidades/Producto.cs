namespace Entidades
{
    public class Producto
    {


        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public byte[] Foto { get; set; }
        public bool EstadoActivo { get; set; }



        public Producto()
        {
        }

        public Producto(string codigo, string descripcion, int existencia, decimal precio, byte[] foto, bool estadoActivo)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Existencia = existencia;
            Precio = precio;
            Foto = foto;
            EstadoActivo = estadoActivo;
        }
    }

}
