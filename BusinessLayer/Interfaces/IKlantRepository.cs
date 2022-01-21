using BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces {
   public interface IKlantRepository {
        bool BestaatKlant(int id);
        Klant KlantToevoegen(Klant klant);
        void KlantVerwijderen(int id);
        void KlantUpdaten(Klant klant);
        Klant KlantWeergeven(int id);

    }
}
