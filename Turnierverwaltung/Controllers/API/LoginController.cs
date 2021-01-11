using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Turnierverwaltung.Controllers.API
{
    public class LoginController : ApiController
    {

        #region Eigenschaften
        private Controller _verwalter;


        #endregion

        #region Accessoren/Modifier
        public Controller Verwalter { get => _verwalter; set => _verwalter = value; }

        #endregion

        #region Konstruktoren
        public LoginController()
        {
            Verwalter = Global.verwalter;
        }
        #endregion

        #region Worker
        // GET: api/Login
        public List<Models.Login> Get()
        {


        }

        // GET: api/Login/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Login
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
        #endregion

    }
}
