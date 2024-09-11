using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day_13_classwork
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public partial class webserviceMath : System.Web.Services.WebService
    {
        [WebMethod]
        public double Add(double a, double b)
        {
            return a + b;
        }
        [WebMethod]
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        [WebMethod]
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        [WebMethod]
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return a / b;
        }
    }      
    public partial class webservice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Day_13_classwork.webserviceMath service = new Day_13_classwork.webserviceMath();
            double result = service.Add(10, 5);
            Label1.Text = "Result: " + result.ToString();
        }
    }

}