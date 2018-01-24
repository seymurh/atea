using AteaPackageManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AteaPackageManager.Services
{
    public class LogService
    {
        public int SelectCount()
        {
            using (var context = new FilmContext())
                return context.Logs.Count();
        }

        public List<Log> GetData(int take, int skip)
        {
            using (var context = new FilmContext())
                return context.Logs.OrderBy(f => f.Id).Skip(skip).Take(take).ToList();
        }
    }
}