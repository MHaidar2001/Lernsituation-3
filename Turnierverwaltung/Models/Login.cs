using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Turnierverwaltung.Models
{
    public class Login
    {
        #region Eigenschaften
        private int _id;
        private string _Username;
        private string _Passwort;
        private string _status;

        #endregion

        #region Accessoren/Modifier
        public int Id { get => _id; set => _id = value; }
        public string Username { get => _Username; set => _Username = value; }
        public string Passwort { get => _Passwort; set => _Passwort = value; }
        public string Status { get => _status; set => _status = value; }

        #endregion

        #region Konstruktoren
        public Login()
        {
            Id = -1;
            Username = "";
            Passwort = "";
            Status = "";
        }
        public Login(int id,string user,string pass,string st)
        {
            Id = id;
            Username = user;
            Passwort = pass;
            Status = st;
        }
        public Login(Login value)
        {
            Id = value.Id;
            Username = value.Username;
            Passwort = value.Passwort;
            Status = value.Status;
        }

        #endregion

        #region Worker
        #endregion
    }
}