using SimuladorExamenUPN.Interfaces;
using SimuladorExamenUPN.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimuladorExamenUPN.Servicios
{
    public class ServicioPregunta : IPregunta
    {
        readonly private ISimuladorContext conte;
        public ServicioPregunta(ISimuladorContext conte)
        {
            this.conte = conte;
        }
        
    }
}