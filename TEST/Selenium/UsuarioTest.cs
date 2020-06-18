using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TEST.Selenium
{
    [TestFixture]
    class UsuarioTest
    {
        [Test]
        public void iniciarSesion()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:58972/Usuario/Login";

            chromeDriver.FindElementById("btnIniciarSesion").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            var paginaSiguiente = chromeDriver.FindElementById("homeExamenes");
            Assert.IsNotNull(paginaSiguiente);

            Thread.Sleep(TimeSpan.FromSeconds(2));
            chromeDriver.Close();
        }

        [Test]
        public void entrarTemas()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:58972/Usuario/Login";

            chromeDriver.FindElementById("btnIniciarSesion").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("temaLink").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            var paginaSiguiente = chromeDriver.FindElementById("pagTemas");
            Assert.IsNotNull(paginaSiguiente);

            Thread.Sleep(TimeSpan.FromSeconds(2));
            chromeDriver.Close();
        }

        [Test]
        public void crearTemas()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:58972/Usuario/Login";

            chromeDriver.FindElementById("btnIniciarSesion").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("temaLink").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("creartemaLink").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("Nombre").SendKeys("Javascript");
            chromeDriver.FindElementById("Categoria").Click();
            chromeDriver.FindElementById("Descripcion").SendKeys("Descripcion de Javascript");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("btnguardartema").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            var paginaSiguiente = chromeDriver.FindElementById("pagTemas");
            Assert.IsNotNull(paginaSiguiente);

            Thread.Sleep(TimeSpan.FromSeconds(2));
            chromeDriver.Close();
        }

        [Test]
        public void EditarTemas()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:58972/Usuario/Login";

            chromeDriver.FindElementById("btnIniciarSesion").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("temaLink").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("editar").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("Nombre").Clear();
            chromeDriver.FindElementById("Nombre").SendKeys("Javascript");
            chromeDriver.FindElementById("Descripcion").Clear();
            chromeDriver.FindElementById("Descripcion").SendKeys("Descripcion de Javascript");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("btnGuardar").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            var paginaSiguiente = chromeDriver.FindElementById("pagTemas");
            Assert.IsNotNull(paginaSiguiente);

            Thread.Sleep(TimeSpan.FromSeconds(2));
            chromeDriver.Close();
        }

        [Test]
        public void EliminarTemas()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:58972/Usuario/Login";

            chromeDriver.FindElementById("btnIniciarSesion").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("temaLink").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("eliminar").Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));

            var paginaSiguiente = chromeDriver.FindElementById("pagTemas");
            Assert.IsNotNull(paginaSiguiente);

            Thread.Sleep(TimeSpan.FromSeconds(2));
            chromeDriver.Close();
        }

        [Test]
        public void preguntasTemas()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:58972/Usuario/Login";

            chromeDriver.FindElementById("btnIniciarSesion").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("temaLink").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("preguntas").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("btnCrear").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("pregunta").SendKeys("¿Cúando se creo Jquery?");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("btnAddAlternativa").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            chromeDriver.FindElementById("alternativa").SendKeys("2001");
            chromeDriver.FindElementById("esCorrecta").Click();
            chromeDriver.FindElementById("btnAddAlternativa").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            chromeDriver.FindElementById("alternativa").SendKeys("1899");
            chromeDriver.FindElementById("btnAddAlternativa").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            chromeDriver.FindElementById("alternativa").SendKeys("1998");
            chromeDriver.FindElementById("btnAddAlternativa").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            chromeDriver.FindElementById("alternativa").SendKeys("1997");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("btnGuardar").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            var paginaSiguiente = chromeDriver.FindElementById("temaEspecifico");
            Assert.IsNotNull(paginaSiguiente);

            Thread.Sleep(TimeSpan.FromSeconds(2));
            chromeDriver.Close();
        }

        [Test]
        public void editarPregunta()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:58972/Usuario/Login";

            chromeDriver.FindElementById("btnIniciarSesion").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("temaLink").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("preguntas").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("btnEditar").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("editarPregunta").Clear();
            chromeDriver.FindElementById("editarPregunta").SendKeys("¿Cúando se creo JavaScript?");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("btnGuardar").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            var paginaSiguiente = chromeDriver.FindElementById("temaEspecifico");
            Assert.IsNotNull(paginaSiguiente);

            Thread.Sleep(TimeSpan.FromSeconds(2));
            chromeDriver.Close();
        }

        [Test]
        public void eliminarPregunta()
        {
            var chromeDriver = new ChromeDriver();
            chromeDriver.Url = "http://localhost:58972/Usuario/Login";

            chromeDriver.FindElementById("btnIniciarSesion").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("temaLink").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("preguntas").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            chromeDriver.FindElementById("btnEliminar").Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            var paginaSiguiente = chromeDriver.FindElementById("temaEspecifico");
            Assert.IsNotNull(paginaSiguiente);

            Thread.Sleep(TimeSpan.FromSeconds(2));
            chromeDriver.Close();
        }
    }
}
