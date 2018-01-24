using AteaPackageManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AteaPackageManager
{
    public partial class About : Page
    {
        public Film Film { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request.QueryString["id"];
            if (!string.IsNullOrEmpty(id))
            {
                int filmId = Convert.ToInt32(id);
                Film = new FilmContext().Films.Find(filmId);
            }
            
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            var url = $"Pages/NewFilm.aspx?id={Film.Id}";
            Response.Redirect(url);
        }
    }
}