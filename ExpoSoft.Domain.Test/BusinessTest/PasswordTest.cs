using NUnit.Framework;
using ExpoSoft.Infrastructure.Data.ObjectMother;

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
        * CUANDO se ingresa una contraseña igual a la anterior.
        * 
        * ENTONCES el sistema presentará un mensaje. 
        *** ("La contraseña que está intentando ingresar es igual a la anterior, intente con una contraseña diferente.").
        */
        [Test]
        public void LaContraseñaNoPuedeSerIgualALaAnterior()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();
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
        * CUANDO se ingresa una contraseña vacia.
        * 
        * ENTONCES el sistema presentará un mensaje. 
        *** ("No puede ingresar una contraseña vacia.").
        */
        [Test]
        public void LaContraseñaNoPuedeSerVacia()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();

            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPassword("");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("No puede ingresar una contraseña vacia.", resultado);
        }
        /*
        * Modificar contraseña
        *** H1: Como empresa, quiero modificar mi contraseña de acceso en el sistema para tener mayor seguridad.
        *
        * Criterio de Aceptación:
        *** 1.6 La contraseña debe contener mínimo ocho caracteres.
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
        * CUANDO se ingresa una contraseña con menos de ocho caracteres.
        * 
        * ENTONCES el sistema presentará un mensaje. 
        *** ("La contraseña debe tener un minimo de 8 caracteres.").
        */
        [Test]
        public void LaContraseñaNoPuedeTenerMenosDeOchoCaracteres()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();
            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPassword("ABCDe1$");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("La contraseña no puede tener menos de 8 caracteres y más de 15 caracteres.", resultado);
        }
        /*
        * Modificar contraseña
        *** H1: Como empresa, quiero modificar mi contraseña de acceso en el sistema para tener mayor seguridad.
        *
        * Criterio de Aceptación:
        *** 1.7 La contraseña debe contener máximo quince caracteres.
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
        * CUANDO se ingresa una contraseña con más de quince caracteres.
        * 
        * ENTONCES el sistema presentará un mensaje. 
        *** ("La contraseña no puede tener menos de 8 caracteres y más de 15 caracteres.").
        */
        [Test]
        public void LaContraseñaNoPuedeTenerMasDeQuinceCaracteres()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();
            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPassword("ABCDEFGHi1$23456");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("La contraseña no puede tener menos de 8 caracteres y más de 15 caracteres.", resultado);
        }
        /*
        * Modificar contraseña
        *** H1: Como empresa, quiero modificar mi contraseña de acceso en el sistema para tener mayor seguridad.
        *
        * Criterio de Aceptación:
        *** 1.5 La contraseña no debe contener espacio.
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
        * CUANDO se ingresa una contraseñaque contiene espacios.
        * 
        * ENTONCES el sistema presentará un mensaje. 
        *** ("La contraseña no debe contener espacios.").
        */
        [Test]
        public void LaContraseñaNoPuedeTenerEspacios()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();
            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPassword("ABCDEFGHi1$ ");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("La contraseña no debe contener espacios.", resultado);
        }
        /*
        * Modificar contraseña
        *** H1: Como empresa, quiero modificar mi contraseña de acceso en el sistema para tener mayor seguridad.
        *
        * Criterio de Aceptación:
        *** 1.1 La contraseña debe contener por lo menos una letra mayúscula.
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
        * CUANDO se ingresa una contraseña que no tiene mayusculas
        * 
        * ENTONCES el sistema presentará un mensaje. 
        *** ("La contraseña debe tener al menos una letra en minuscula, mayuscula, un número y un caracteres especial.").
        */
        [Test]
        public void LaContraseñaNoTieneMayusculas()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();
            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPassword("abcdefghi1$");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("La contraseña debe tener al menos una letra en minuscula, mayuscula, un número y un caracteres especial.", resultado);
        }
        /*
        * Modificar contraseña
        *** H1: Como empresa, quiero modificar mi contraseña de acceso en el sistema para tener mayor seguridad.
        *
        * Criterio de Aceptación:
        *** 1.2 La contraseña debe contener por lo menos una letra minúscula.
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
        * CUANDO se ingresa una contraseña que no tiene minusculas
        * 
        * ENTONCES el sistema presentará un mensaje. 
        *** ("La contraseña debe tener al menos una letra en minuscula, mayuscula, un número y un caracteres especial.").
        */
        [Test]
        public void LaContraseñaNoTieneMinusculas()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();
            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPassword("ABCDEFGHI1$");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("La contraseña debe tener al menos una letra en minuscula, mayuscula, un número y un caracteres especial.", resultado);
        }
        /*
        * Modificar contraseña
        *** H1: Como empresa, quiero modificar mi contraseña de acceso en el sistema para tener mayor seguridad.
        *
        * Criterio de Aceptación:
        *** 1.4 La contraseña debe contener por lo menos un número.
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
        * CUANDO se ingresa una contraseña que no tiene minusculas
        * 
        * ENTONCES el sistema presentará un mensaje. 
        *** ("La contraseña debe tener al menos una letra en minuscula, mayuscula, un número y un caracteres especial.").
        */
        [Test]
        public void LaContraseñaNoTieneNumeros()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();
            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPassword("ABCDEFGHi$");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("La contraseña debe tener al menos una letra en minuscula, mayuscula, un número y un caracteres especial.", resultado);
        }
        /*
        * Modificar contraseña
        *** H1: Como empresa, quiero modificar mi contraseña de acceso en el sistema para tener mayor seguridad.
        *
        * Criterio de Aceptación:
        *** 1.3 La contraseña debe contener por lo menos un caracter especial.
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
        * CUANDO se ingresa una contraseña que no tiene caracteres especiales
        * 
        * ENTONCES el sistema presentará un mensaje. 
        *** ("La contraseña debe tener al menos una letra en minuscula, mayuscula, un número y un caracteres especial.").
        */
        [Test]
        public void LaContraseñaNoTieneCaracteresEspeciales()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();
            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPassword("ABCDEFGHi1");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("La contraseña debe tener al menos una letra en minuscula, mayuscula, un número y un caracteres especial.", resultado);
        }
        /*
        * Modificar contraseña
        *** H1: Como empresa, quiero modificar mi contraseña de acceso en el sistema para tener mayor seguridad.
        *
        * Criterio de Aceptación:
        *** 1.0 La contraseña no puede ser igual a la anterior.
        *** 1.1 La contraseña debe contener por lo menos una letra mayúscula.
        *** 1.2 La contraseña debe contener por lo menos una letra minúscula.
        *** 1.3 La contraseña debe contener por lo menos un caracter especial.
        *** 1.4 La contraseña debe contener por lo menos un número.
        *** 1.5 La contraseña no debe contener espacio.
        *** 1.6 La contraseña debe contener mínimo ocho caracteres
        *** 1.7 La contraseña debe contener máximo quince caracteres.
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
        * CUANDO se ingresa una contraseña que no tiene caracteres especiales
        * 
        * ENTONCES el sistema presentará un mensaje. 
        *** ("¡La password es correcta!").
        */
        [Test]
        public void LaContraseñaCumpleConLosCriteriosDeAceptacion()
        {
            //ARRANGE //PREPARAR // DADO // GIVEN
            var business = BusinessMother.CreateBusiness();
            // ACT // ACCION // CUANDO // WHEN
            var resultado = business.ModifyPassword("ABCDEFGHi1/");
            //ASSERT //AFIRMACION //ENTONCES //THEN
            Assert.AreEqual("¡La password es correcta!", resultado);
        }
    }
}
