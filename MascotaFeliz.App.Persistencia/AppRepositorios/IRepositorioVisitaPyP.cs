using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVisitaPyP
    {
        IEnumerable<VisitaPyP> GetAllVisitaPyP();
        VisitaPyP AddVisitaPyP(VisitaPyP mascota);
        VisitaPyP UpdateVisitaPyP(VisitaPyP visitaPyP);
        void DeleteVisitaPyP(int idVisitaPyP);
        VisitaPyP GetVisitaPyP(int idVisitaPyP);
        //IEnumerable<VisitaPyP> GetVisitaPyPPorFiltro(string filtro);
    }
}