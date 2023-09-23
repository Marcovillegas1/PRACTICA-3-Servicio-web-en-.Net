using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AreaWS
{
    /// <summary>
    /// Descripción breve de AreaWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreaWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public decimal AreaCuadrado(decimal lado1, decimal lado2)
        {
            Operaciones o = new Operaciones();
            return o.cuadrado(lado1, lado2);

        }
        [WebMethod]
        public decimal AreaTriangulo(decimal largo, decimal ancho)
        {
            Operaciones o = new Operaciones();
            return o.triangulo(largo, ancho);
        }
        [WebMethod]
        public double AreaCirculo(double radio)
        {
            Operaciones o = new Operaciones();
            return o.circulo(radio);
        }
    }
}
