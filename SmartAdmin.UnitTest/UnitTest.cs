using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Agilecore.Domain;
using Agilecore.Data.Model;

namespace SmartAdmin.UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Teste()
        {
            var Domain = new Agilecore.Domain.UnitOfWork();
            var Model = new Agilecore.Data.Model.MenuDto();

            Model.ACTION = "s";
            Model.CONTROLLER = "sdsa";
            Model.DESCRICAO = "sas";
            Model.DTH_CADASTRO = DateTime.Now;
            Model.ICONE = "sa";
            Model.NOME = "sadad";
            Model.STATUS = "A";

            Domain.MenuDomain.Save(Model);
        }
    }
}
