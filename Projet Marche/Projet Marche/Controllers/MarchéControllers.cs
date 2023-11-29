using Projet_Marche.DAO;
using Projet_Marche.Entities;
using Projet_Marche.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Marche.Controllers
{
    public class MarchéControllers
    {
        MarcheService marcheService;
        public MarchéControllers()
        {
            marcheService = new MarcheService();
        }

        public March Save(string NomMarche, string AdresseMarche, string Description)
        {
            March marche = new March
            {
                NomMarche = NomMarche,
                AdresseMarche = AdresseMarche,
                Description = Description
            };
            return marcheService.Save(marche);
        }

        public List<March> FindAll()
        {
            return marcheService.FindAll();
        }

        public March Update(March marche)
        {
            return marcheService.Update(marche);
        }

        public int Delete(int id)
        {
            return marcheService.Delete(id);
        }

        public bool Exists(int id)
        {
            return marcheService.Exists(id);
        }

        public March FindById(int id)
        {
            return marcheService.FindById(id);
        }

        public March FindByName(string name)
        {
            return marcheService.FindByName(name);
        }

        public List<March> FilterByName(string name)
        {
            return marcheService.FilterByName(name);
        }
    }
}
