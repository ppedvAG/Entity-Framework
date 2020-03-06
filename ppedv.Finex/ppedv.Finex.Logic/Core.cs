using ppedv.Finex.Model;
using ppedv.Finex.Model.Contracts;
using System;
using System.Linq;

namespace ppedv.Finex.Logic
{
    public class Core
    {
        public IRepository Repository { get; private set; }


        public Medikament GetMedikamentWithMostLagerbestand()
        {

            return Repository.Query<Medikament>().OrderByDescending(x => x.Lager.Sum(l => l.Bestand)).ThenBy(x => x.Name).FirstOrDefault();
        }

        public Core(IRepository repo)
        {
            Repository = repo;
        }


        public Core() : this(new Data.EF.EfRepository())
        { }
    }
}
