using NUnit.Framework;
using ExpoSoft.Domain.Entities;
using ExpoSoft.Domain.Test.BusinessTest;

namespace ExpoSoft.Domain.Test.BusinessTest
{
    class PhoneNumberTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ElNumeroCelularSoloPuedeTenerDiezDigitos()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();

            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPhoneNumber("30045651791");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("El número celular debe tener 10 digitos.", resultado);
        }
        [Test]
        public void ElNumeroCelularNoSoloTieneNumeros()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();

            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPhoneNumber("300456517/");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("El número celular solo puede contener números.", resultado);
        }
        [Test]
        public void ElNumeroCelularSoloContieneNumerosYEstaEnElRangoDeCaracteres()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();

            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPhoneNumber("3004565179");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("¡El número telefonico 3004565179 es correcto!", resultado);
        }
    }
}
