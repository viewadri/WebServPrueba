using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page
{
    edad.Service wsEdad = new edad.Service();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //wsEdad.Fecha(txtdia.Text,txtmes.Text,txtanio.Text);
        lblresult.Text = wsEdad.Fecha(txtdia.Text, txtmes.Text, txtanio.Text);

    }
}
