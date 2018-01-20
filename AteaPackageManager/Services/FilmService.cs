using AteaPackageManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AteaPackageManager.Services
{
    public class FilmService
    {
        public int SelectCount()
        {
            FilmContext context = new FilmContext();
            return context.Films.Count();
        }

        //public List<Film> GetData()
        //{
        //    var index = GridViewFilms.PageIndex;
        //    index = index > 0 ? index : 1;
        //    var size = GridViewFilms.PageSize;
        //    FilmContext context = new FilmContext();
        //    return context.Films.OrderBy(f => f.Id).Skip(size * (index - 1)).Take(size).ToList();
        //}

        public List<Film> GetData(int take, int skip)
        {
            FilmContext context = new FilmContext();
            return context.Films.OrderBy(f => f.Id).Skip(skip).Take(take).ToList();
        }
    }
}