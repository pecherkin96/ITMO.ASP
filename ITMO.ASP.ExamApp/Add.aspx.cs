using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ITMO.ASP.ExamApp
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Page.Validate();
                if (!Page.IsValid)
                    return;

                Studentstable studentline = new Studentstable(firstname.Text, lastname.Text, int.Parse(mark.Text));
                try
                {
                    SampleContext context = new SampleContext();
                    context.Studentstable.Add(studentline);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Response.Redirect("Ошибка " + ex.Message);
                }
            }
        }
    }
}