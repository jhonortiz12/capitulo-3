namespace ejercicio3
{
    public class   program
    {
        public static void Main()
        {
            double factura, descuento, precio, preciobruto, ivacompra;
            int cantidadproduct;
            Console.WriteLine("ingrese el precio del producto");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad que va a llevar");
            cantidadproduct = int.Parse(Console.ReadLine());
            ivacompra = (precio * cantidadproduct) * 0.12;
            Console.WriteLine("el iva de un valor es de " + ivacompra);
            preciobruto = (precio * cantidadproduct) * ivacompra;
            if (preciobruto > 50000)
            {
                descuento = preciobruto * 0.05;
                factura = preciobruto - descuento;








            }
            else
            {
                factura = preciobruto;

           
            
            }

            Console.WriteLine("el precio de la factura es de ");
        }    
    }
}
