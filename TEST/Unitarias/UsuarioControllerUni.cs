using Moq;
using NUnit.Framework;
using SimuladorExamenUPN.Controllers;
using SimuladorExamenUPN.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TEST.Unitarias
{

    [TestFixture]
    public  class UsuarioControllerUni
    {
        [Test]
        public void LogeuoUsuario()
        {
            string username = "admin";
            string password = "admin";
            var mocksession = new Mock<ISession>();
            mocksession.Setup(o => o.LogueoUsuario(username, password));
            var controler = new UsuarioController(mocksession.Object);
            var view = controler.Login(username, password) as ViewResult;
            Assert.IsInstanceOf<ViewResult>(view);
            mocksession.Verify(o => o.LogueoUsuario(username, password), Times.Once);
        }
    }
}
