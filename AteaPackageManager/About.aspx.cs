using AteaPackageManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace AteaPackageManager
{
    public partial class About : Page
    {
        public Film Film { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var id = Request.QueryString["id"];
                if (!string.IsNullOrEmpty(id))
                {
                    int filmId = Convert.ToInt32(id);
                    using (var context = new FilmContext())
                    {
                        Film = context.Films.Find(filmId);
                        context.Entry(Film).Reference(f => f.Producer).Load();
                        context.Logs.Add(new Log { UserId = User.Identity.GetUserId(), Name = User.Identity.GetUserName(), Description = $"entered details of {Film.Id}" });
                        context.SaveChanges();
                    }
                }
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            var id = Request.QueryString["id"];
            var url = $"Pages/NewFilm.aspx?id={id}";
            Response.Redirect(url);
        }
    }
}