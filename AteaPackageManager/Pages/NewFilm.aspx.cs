using AteaPackageManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AteaPackageManager.Pages
{
    public partial class NewFilm : System.Web.UI.Page
    {
        public Film Film { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request.QueryString["Id"];
            Film = GetFilm(id);
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
            using (FilmContext context = new FilmContext())
            {
                var contextFilm = context.Films.Find(Film.Id);
                try
                {
                    if (contextFilm != null)
                    {
                        context.Entry(contextFilm).CurrentValues.SetValues(Film);
                        context.SaveChanges();
                    }
                    else
                    {
                        context.Films.Add(Film);
                        context.SaveChanges();
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    var errors = context.GetValidationErrors().SelectMany(er => er.ValidationErrors);
                    foreach (var error in errors)
                    {
                        ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                    }
                }
            }

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