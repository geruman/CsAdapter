using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAdapter.Tests
{
    [TestClass()]
    public class ClientTests
    {
        private Cliente cliente;
        [TestInitialize()]
        public void TestInitialize()
        {
            Console.Write("Creando objeto");
            cliente = new Cliente();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            cliente = null;
            Console.Write("Cliente nuleado");
        }
        [TestMethod()]
        public void TestServicioWeb()
        {
            cliente.SetServicio(new ServicioWeb());
            Assert.AreEqual(cliente.EnviarInfoAlServicio("Esta es la información"),true);
        }
        [TestMethod()]
        public void TestServicioAdapter()
        {
            cliente.SetServicio(new SerivicioArchivoAdapter());
            Assert.AreEqual(cliente.EnviarInfoAlServicio("Informacion para el archivo"),true);
        }
        
    }
}