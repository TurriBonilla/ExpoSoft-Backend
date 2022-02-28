using NUnit.Framework;
using ExpoSoft.Domain.Entities;

namespace ExpoSoft.Domain.Test.BusinessTest
{
    class PasswordTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /*
         * Modificar contraseña
         *** H1: Como empresa, quiero modificar mi contraseña de acceso en el sistema para tener mayor seguridad.
         *
         * Criterio de Aceptación:
         *** 1.0 La contraseña no puede ser igual a la anterior.
         *
         * DADO que la empresa tiene una cuenta en el sistema con los siguientes datos:
         * Nombre: ExpoSoft
         * Nit: 1524587
         * Teléfono celular: 301 273 68 97
         * Teléfono fijo: 570 85 02
         * Contraseña: ExpoSoft123@
         * Email: exposoft@exposoft.com
         * Año de constitución: 2021
         * Tipo de empresa: Informática
         * Ubicación de la empresa: Valledupar
         * 
         * CUANDO se ingresa una contraseña igual a la anterior.
         * 
         * ENTONCES el sistema presentará un mensaje. 
         *** ("La contraseña que está intentando ingresar es igual a la anterior, intente con una contraseña diferente.").
        */

        [Test]
        public void LaContraseñaNoPuedeSerIgualALaAnterior()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = new Business("ExpoSoft", "1524587", "3012736897", "5708502", "ExpoSoft123@", "exposoft@exposoft.com", "2021", "Informática", "Valledupar", "CRR 5A #20-4", "Jhade");
            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPassword("ExpoSoft123@");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("La contraseña que está intentando ingresar es igual a la anterior, intente con una contraseña diferente.", resultado);
        }

        /*
         * Modificar contraseña
         *** H1: Como empresa, quiero modificar mi contraseña de acceso en el sistema para tener mayor seguridad.
         *
         * Criterio de Aceptación:
         *** 1.0 La contraseña ingresada es vacia.
         *
         * DADO que la empresa tiene una cuenta en el sistema con los siguientes datos:
         * Nombre: ExpoSoft
         * Nit: 1524587
         * Teléfono celular: 301 273 68 97
         * Teléfono fijo: 570 85 02
         * Contraseña: ExpoSoft123@
         * Email: exposoft@exposoft.com
         * Año de constitución: 2021
         * Tipo de empresa: Informática
         * Ubicación de la empresa: Valledupar
         * 
         * CUANDO se ingresa una contraseña vacia.
         * 
         * ENTONCES el sistema presentará un mensaje. 
         *** ("No puede ingresar una contraseña vacia.").
        */

        [Test]
        public void LaContraseñaNoPuedeSerVacia()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = new Business("ExpoSoft", "1524587", "3012736897", "5708502", "ExpoSoft123@", "exposoft@exposoft.com", "2021", "Informática", "Valledupar", "CRR 5A #20-4", "Jhade");
            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPassword("");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("No puede ingresar una contraseña vacia.", resultado);
        }
    }
}
