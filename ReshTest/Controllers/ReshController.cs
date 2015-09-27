using ReshTest.Models;
using ReshTest.ServiceReference1;
using ReshTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ReshTest.Controllers
{
    //usikker på om dette er riktig måte å gjøre det på 
    [EnableCors(origins: "http://reshclient.azurewebsites.net", headers: "*", methods: "*")]
    public class ReshController : ApiController
    {

        private ReshRepository reshRepository;

        public ReshController()
        {
            this.reshRepository = new ReshRepository();
        }

        public ReshUnit Get(int id)
        {
            return this.reshRepository.getUnitById(id);
        }
    }
}
