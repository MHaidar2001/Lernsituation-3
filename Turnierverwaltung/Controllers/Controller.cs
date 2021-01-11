using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Turnierverwaltung.Models;

namespace Turnierverwaltung
{
    public class Controller
    {
        #region Eigenschaften
        private List<Models.Login> _list;


        #endregion

        #region Accessoren/Modifier
        public List<Login> List { get => _list; set => _list = value; }

        #endregion

        #region Konstruktoren
        public Controller()
        {
            List =  new List<Models.Login>();
        }
        #endregion

        #region Worker
        #endregion
    }
}