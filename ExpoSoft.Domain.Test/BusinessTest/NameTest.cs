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
        /*
        * Modificar Nombre
        *** H3: 
        *
        * Criterio de Aceptación:
        *** 1.0 El nombre es requerido.
        *
        * DADO que la empresa tiene una cuenta en el sistema con los siguientes datos:
        * Nombre: ExpoSoft
        * Nit: 1524587
        * Teléfono celular: 3012736897
        * Teléfono fijo: 5708502
        * Contraseña: ExpoSoft123@
        * Email: exposoft@exposoft.com
        * Año de constitución: 2021
        * Tipo de empresa: Informática
        * Departamento: Cesar
        * Ciudad: Valledupar
        * Nombre del propietario: Jhade 
        * Apellidos del propietario: Bonilla
        * 
        * CUANDO se ingresa un nombre de empresa vacio
        * 
        * ENTONCES el sistema presentará un mensaje. 
        *** ("El nombre es requerido.").
        */
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
        /*
        * Modificar Nombre
        *** H3: 
        *
        * Criterio de Aceptación:
        *** 1.0 El nombre es requerido.
        *
        * DADO que la empresa tiene una cuenta en el sistema con los siguientes datos:
        * Nombre: ExpoSoft
        * Nit: 1524587
        * Teléfono celular: 3012736897
        * Teléfono fijo: 5708502
        * Contraseña: ExpoSoft123@
        * Email: exposoft@exposoft.com
        * Año de constitución: 2021
        * Tipo de empresa: Informática
        * Departamento: Cesar
        * Ciudad: Valledupar
        * Nombre del propietario: Jhade 
        * Apellidos del propietario: Bonilla
        * 
        * CUANDO se ingresa un nombre que no solo contiene letras.
        * 
        * ENTONCES el sistema presentará un mensaje. 
        *** ("El nombre solo puede tener letras.").
        */
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
        /*
        * Modificar Nombre
        *** H3: 
        *
        * Criterio de Aceptación:
        *** 1.0 El nombre es requerido.
        *
        * DADO que la empresa tiene una cuenta en el sistema con los siguientes datos:
        * Nombre: ExpoSoft
        * Nit: 1524587
        * Teléfono celular: 3012736897
        * Teléfono fijo: 5708502
        * Contraseña: ExpoSoft123@
        * Email: exposoft@exposoft.com
        * Año de constitución: 2021
        * Tipo de empresa: Informática
        * Departamento: Cesar
        * Ciudad: Valledupar
        * Nombre del propietario: Jhade 
        * Apellidos del propietario: Bonilla
        * 
        * CUANDO se ingresa un nombre que tienes menos de 3 letras
        * 
        * ENTONCES el sistema presentará un mensaje. 
        *** ("No puede ingresar un nombre con menos de 3 caracteres y más de 30 caracteres.").
        */
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
        /*
        * Modificar Nombre
        *** H3: 
        *
        * Criterio de Aceptación:
        *** 1.0 El nombre es requerido.
        *
        * DADO que la empresa tiene una cuenta en el sistema con los siguientes datos:
        * Nombre: ExpoSoft
        * Nit: 1524587
        * Teléfono celular: 3012736897
        * Teléfono fijo: 5708502
        * Contraseña: ExpoSoft123@
        * Email: exposoft@exposoft.com
        * Año de constitución: 2021
        * Tipo de empresa: Informática
        * Departamento: Cesar
        * Ciudad: Valledupar
        * Nombre del propietario: Jhade 
        * Apellidos del propietario: Bonilla
        * 
        * CUANDO se ingresa un nombre con más de 15 letras
        * 
        * ENTONCES el sistema presentará un mensaje. 
        *** ("No puede ingresar un nombre con menos de 3 caracteres y más de 30 caracteres.").
        */
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
        /*
        * Modificar Nombre
        *** H3: 
        *
        * Criterio de Aceptación:
        *** 1.0 El nombre es requerido.
        *
        * DADO que la empresa tiene una cuenta en el sistema con los siguientes datos:
        * Nombre: ExpoSoft
        * Nit: 1524587
        * Teléfono celular: 3012736897
        * Teléfono fijo: 5708502
        * Contraseña: ExpoSoft123@
        * Email: exposoft@exposoft.com
        * Año de constitución: 2021
        * Tipo de empresa: Informática
        * Departamento: Cesar
        * Ciudad: Valledupar
        * Nombre del propietario: Jhade 
        * Apellidos del propietario: Bonilla
        * 
        * CUANDO se ingresa un nombre que cumple con todos los criterios de aceptación
        * 
        * ENTONCES el sistema presentará un mensaje. 
        *** ("¡El nombre abcdefghijklmnopqabcdef es correcto!").
        */
        [Test]
        public void ElNombreCumpleConLosCriteriosDeAceptacion()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();
            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyName("abcdefghijklmnopqabcdef");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("¡El nombre abcdefghijklmnopqabcdef es correcto!", resultado);
        }
    }
}