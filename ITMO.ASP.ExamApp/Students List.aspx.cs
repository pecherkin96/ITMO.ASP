using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITMO.ASP.ExamApp
{
    public partial class Students_List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                SampleContext context = new SampleContext();
                var markQuery = from b in context.Studentstable                                
                                select b.Mark;
                int Sum = markQuery.Sum();
                SumLiteral.Text = Sum.ToString();
            }
        }
    }
}