using NUnit.Framework;
using ExpoSoft.Domain.Entities;
using ExpoSoft.Domain.Test.BusinessTest;

namespace ExpoSoft.Domain.Test.BusinessTest
{
    class EmailTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ElEmailNoPuedeSerVacio()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();

            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyEmail("");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("El email no puede estar vacio.", resultado);
        }
        [Test]
        public void ElEmailNoCumpleConElFormato()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();

            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyEmail("asss@");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("El email no cumple con el formato establecido Ej: \"email@correo.com\".", resultado);
        }
    }
}
