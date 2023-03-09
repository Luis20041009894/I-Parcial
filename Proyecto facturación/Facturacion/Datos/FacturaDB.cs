namespace Datos
{
    internal class FacturaDB
    {
        string cadena = "server=localhost; user=root; database=factura_LM; password=Shinigam96!;";

        //public bool Guardar(Factura factura, List<DetalleFactura> detalles)//falta Factura en Entidades
        //{
        //    bool inserto = false;
        //    int idFactura = 0;
        //    try
        //    {
        //        StringBuilder sqlFactura = new StringBuilder();
        //        sqlFactura.Append("INSERT INTO factura VALUES (@Fecha, @IdentidadCliente, @CodigoUsuario, @ISV, @subtotal, @Total);");
        //        sqlFactura.Append("SELECT LAST INSERT_ID(); ");

        //        StringBuilder sqlDetalle = new StringBuilder();
        //        sqlDetalle.Append("INSERT INTO detallefactura VALUES (@IdFactura, @CodigoProducto, @Precio, @Cantidad, @Total); ");

        //        StringBuilder sqlExistencia = new StringBuilder();
        //        sqlExistencia.Append("UPDATE producto SET Existencia = Existencia - @Cantidad WHERE codigo = @Codigo; ");
        //    }
        //    catch (System.Exception)
        //    {

        //    }
        //    return inserto;


        //}
    }
}
