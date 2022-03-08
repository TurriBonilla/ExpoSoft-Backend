using ExpoSoft.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ExpoSoft.Domain.Entities
{
    public class Business : Entity<int>, IAggregateRoot
    {
        private string Name { get; set; }
        private string Nit { get; set; }
        private string Phone { get; set; }
        private string Landline { get; set; }
        private string Password { get; set; }
        private string Email { get; set; }
        private string YearOfConstitution { get; set; }
        private string TypeOfBusiness { get; set; }
        private string Location { get; set; }
        private string Address { get; set; }
        private string Owner { get; set; }

        public Business(string name, string nit, string phone, string landline, string password, string email, string yearOfConstitution, string typeOfBusiness, string location, string address, string owner)
        {
            Name = name;
            Nit = nit;
            Phone = phone;
            Landline = landline;
            Password = password;
            Email = email;
            YearOfConstitution = yearOfConstitution;
            TypeOfBusiness = typeOfBusiness;
            Location = location;
            Address = address;
            Owner = owner;
        }

        public string ModifyPassword(string password)
        {
            if (password.Equals(""))
            {
                return "No puede ingresar una contraseña vacia.";
            }
            if (Password.Equals(password))
            {
                return "La contraseña que está intentando ingresar es igual a la anterior, intente con una contraseña diferente.";
            }
            if (password.Length < 8)
            {
                return "La contraseña debe tener un minimo de 8 caracteres.";
            }
            if (password.Length > 15)
            {
                return "La contraseña debe tener como maximo 15 caracteres.";
            }
            if (password.Contains(" "))
            {
                return "La contraseña no debe contener espacios.";
            }
            if (!password.Any(c => char.IsLower(c)))
            {
                return "La contraseña debe tener al menos una minuscula.";
            }
            if (!password.Any(c => char.IsUpper(c)))
            {
                return "La contraseña debe tener al menos una mayuscula.";
            }
            if (!password.Any(c => char.IsNumber(c)))
            {
                return "La contraseña debe tener al menos un número.";
            }
            if (!password.Any(c => {
                int asciChar = (int)c;

                return (
                    (asciChar >= 33 && asciChar <= 47) || 
                    (asciChar >= 58 && asciChar <= 64) ||
                    (asciChar >= 91 && asciChar <= 96) ||
                    (asciChar >= 123 && asciChar <= 126)
                );
            }))
            {
                return "La contraseña debe tener al menos un caracter especial.";
            }

            throw new NotImplementedException();
        }
        public string ModifyPhoneNumber(string phoneNumber)
        {
            if (!phoneNumber.Length.Equals(10) )
            {
                return "El número celular debe tener 10 digitos.";
            }
            if (phoneNumber.Any(c => !char.IsNumber(c)))
            {
                return "El número celular solo puede contener números.";
            }

            throw new NotImplementedException();
        }
        public string ModifyEmail(string email)
        {
            if (email.Equals(""))
            {
                return "El email no puede estar vacio.";
            }
            if (!new EmailAddressAttribute().IsValid(email))
            {
                return "El email no cumple con el formato establecido Ej: \"email@correo.com\".";
            }

            throw new NotImplementedException();
        }
    }
}
