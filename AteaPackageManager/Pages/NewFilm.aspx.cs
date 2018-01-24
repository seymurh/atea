using AteaPackageManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using AteaPackageManager.Services;

namespace AteaPackageManager.Pages
{
    public partial class NewFilm : System.Web.UI.Page
    {
        private FilmService filmService { get; set; } = new FilmService();

        public Film Film
        {
            get { return (Film)Session["film"]; }
            set { Session["film"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var id = Request.QueryString["id"];
                Film = GetFilm(id);
                txtName.Text = Film.Name;
                category.Text = Film.Category;
                if (Film?.ReleaseDate != null)
                    releaseDate.SelectedDate = Film.ReleaseDate.Value;
                if (Film?.ProducerId != null)
                    producer.SelectedValue = Film.ProducerId.ToString();
            }
        }

        public Film GetFilm(string id)
        {
            using (FilmContext context = new FilmContext())
            {
                return id == null ? new Film() : context.Films.Find(Convert.ToInt32(id));
            }
        }

        public IEnumerable<Producer> GetProducers()
        {
            using (FilmContext context = new FilmContext())
            {
                return context.Producers.ToList();
            }
        }

        public void InsertOrUpdateFilm(object sender, EventArgs e)
        {
            BindFilm();
            filmService.InsertOrUpdateFilm(Film, User.Identity, ModelState);
        }

        protected void BindFilm()
        {
            Film.Name = txtName.Text;
            Film.Category = category.Text;
            Film.ReleaseDate = releaseDate.SelectedDate;
            if (!string.IsNullOrEmpty(producer.SelectedValue))
                Film.ProducerId = Convert.ToInt32(producer.SelectedValue);
        }
    }
}