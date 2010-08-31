using System;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Eliminar la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }
    [WebMethod]
    
    public String Fecha(String dia, String mes ,String anio) 
    {
        string mensaje = "";
        DateTime FechaNacimiento;

        try
        {
             FechaNacimiento = new DateTime(int.Parse(anio), int.Parse(mes), int.Parse(dia));

        }
        catch (Exception e)
        {
            mensaje = "<Error>Error en el formato de los números </error>";
            return mensaje;

        }

        
        DateTime fechaActual = DateTime.Today;
        int edad = fechaActual.Year - FechaNacimiento.Year;
        if (DateTime.Now.Month < FechaNacimiento.Month ||
            (DateTime.Now.Month == FechaNacimiento.Month && DateTime.Now.Day < FechaNacimiento.Day))
        {
           edad--;
        }
        
         mensaje = edad.ToString();

        return mensaje;
    }

}
