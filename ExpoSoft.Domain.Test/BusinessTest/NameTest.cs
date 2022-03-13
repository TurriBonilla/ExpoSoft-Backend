using NUnit.Framework;
using ExpoSoft.Infrastructure.Data.ObjectMother;

namespace ExpoSoft.Domain.Test.BusinessTest
{
    class NameTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ElNombreNoPuedeSerVacia()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();

            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyName("");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("El nombre es requerido.", resultado);
        }
        [Test]
        public void ElNombreNoTieneSoloLetras()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();

            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyName("123soka");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("El nombre solo puede tener letras.", resultado);
        }
        [Test]
        public void ElNombreNoPuedeTenerMenosDeTresLetras()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();

            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyName("so");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("No puede ingresar un nombre con menos de 3 caracteres y más de 30 caracteres.", resultado);
        }

        [Test]
        public void ElNombreNoPuedeTenerMasDeQuinceLetras()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();

            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyName("abcdefghijklmnopqabcdefghijklmnopq");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("No puede ingresar un nombre con menos de 3 caracteres y más de 30 caracteres.", resultado);
        }
    }
}