﻿using System.Web.Http;
using System.Web.Mvc;
using WebApplication2.DataProviders;
using WebApplication2.Entites;

namespace WebApplication2.Controllers
{
    public class FacturesController : ApiController
    {


        public bool Post([FromBody] Facture facture)
        {
            FactureDataProvider factureDataProvider = new FactureDataProvider();
            return factureDataProvider.EnregistrerFacture(facture);
        }

        public bool Post(Photo photo, [FromUri] int id)
        {
            FactureDataProvider factureDataProvider = new FactureDataProvider();
            return factureDataProvider.AjouterPhoto(id, photo);
        }

        public bool Put(Facture facture)
        {
            FactureDataProvider factureDataProvider = new FactureDataProvider();
            return factureDataProvider.ModifierFacture(facture);
        }

        
        [System.Web.Http.HttpGet]
        public Facture GetFacture(int id)
        {
            FactureDataProvider factureDataProvider= new FactureDataProvider();
            return factureDataProvider.TrouverFactureParId(id);
        }

        [System.Web.Http.Route("api/factures/photos/{id}")]
        public Photo Get(int id)
        {
            FactureDataProvider factureDataProvider = new FactureDataProvider();
            return factureDataProvider.TrouverPhotoParId(id);
        }
    }
}