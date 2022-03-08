using NUnit.Framework;
using ExpoSoft.Domain.Entities;

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
            var resultado = business.ModifyEmail("");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("El email no puede estar vacio.", resultado);
        }
        [Test]
        public void ElEmailNoCumpleConElFormato()
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
            var resultado = business.ModifyEmail("asss@");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("El email no cumple con el formato establecido Ej: \"email@correo.com\".", resultado);
        }
    }
}
