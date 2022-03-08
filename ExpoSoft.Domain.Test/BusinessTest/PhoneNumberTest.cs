using NUnit.Framework;
using ExpoSoft.Domain.Entities;

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
            var business = new Business(
                "ExpoSoft",
                "1524587",
                "3012736897",
                "5708502",
                "ExpoSoft123@",
                "exposoft@exposoft.com",
                "2021",
                "Informática",
                "Valledupar",
                "CRR 5A #20-4",
                "Jhade"
                );

            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPhoneNumber("30045651791");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("El número celular debe tener 10 digitos.", resultado);
        }
        [Test]
        public void ElNumeroCelularNoSoloTieneNumeros()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = new Business(
                "ExpoSoft",
                "1524587",
                "3012736897",
                "5708502",
                "ExpoSoft123@",
                "exposoft@exposoft.com",
                "2021",
                "Informática",
                "Valledupar",
                "CRR 5A #20-4",
                "Jhade"
                );

            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPhoneNumber("300456517/");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("El número celular solo puede contener números.", resultado);
        }
    }
}
