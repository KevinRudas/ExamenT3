using SimuladorExamenUPN.DB;
using SimuladorExamenUPN.Interfaces;
using SimuladorExamenUPN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace SimuladorExamenUPN.Servicios
{
    public class SessionServices : ISession
    {
        HttpSessionState session;
        public Usuario LogueoUsuario(string username, string password)
        {
            SimuladorContext cont = new SimuladorContext();
            session = HttpContext.Current.Session;
            Usuario usuario = new Usuario();
            session["Usuario"] = new Usuario { Id = 1, Username = "admin" , Password="admin"};
            return usuario;
        }
    }
}