using AteaPackageManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Security.Principal;
using Microsoft.AspNet.Identity;
using System.Web.ModelBinding;

namespace AteaPackageManager.Services
{
    public class FilmService
    {
        public int SelectCount()
        {
            using (var context = new FilmContext())
                return context.Films.Count();
        }

        public List<Film> GetData(int take, int skip)
        {
            using (var context = new FilmContext())
                return context.Films.OrderBy(f => f.Id).Skip(skip).Take(take).ToList();
        }

        public void InsertOrUpdateFilm(Film film, IIdentity identity, ModelStateDictionary modelState)
        {
            using (FilmContext context = new FilmContext())
            {
                var contextFilm = context.Films.Find(film.Id);
                try
                {
                    if (contextFilm != null)
                    {
                        context.Entry(contextFilm).CurrentValues.SetValues(film);
                        context.Logs.Add(new Log { UserId = identity.GetUserId(), Name = identity.GetUserName(), Description = $"Film with id {film.Id} updated" });
                        context.SaveChanges();
                    }
                    else
                    {
                        context.Films.Add(film);
                        context.Logs.Add(new Log { UserId = identity.GetUserId(), Name = identity.GetUserName(), Description = $"new film added" });
                        context.SaveChanges();
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    var errors = context.GetValidationErrors().SelectMany(er => er.ValidationErrors);
                    foreach (var error in errors)
                    {
                        modelState.AddModelError(error.PropertyName, error.ErrorMessage);
                    }
                }
            }
        }
    }
}