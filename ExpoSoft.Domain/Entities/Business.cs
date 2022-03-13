using ExpoSoft.Domain.Base;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExpoSoft.Domain.Entities
{
    public class Business : Entity<int>, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Nit { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string TypeOfBusiness { get; private set; }
        public string Department { get; private set; }
        public string Town { get; private set; }
        public string OwnerName { get; private set; }
        public string OwnerlastName { get; private set; }
        public Score Score { get; private set; }
        public List<HistoricalScore> HistoricalScores { get; set; }

        public Business() { }

        public Business(string name, string nit, string email, string password, string typeOfBusiness, string department, string town, string ownerName, string ownerlastName)
        {
            Name = name;
            Nit = nit;
            Email = email;
            Password = password;
            TypeOfBusiness = typeOfBusiness;
            Department = department;
            Town = town;
            OwnerName = ownerName;
            OwnerlastName = ownerlastName;
            Score = null;
            HistoricalScores = null;
        }

        public string ModifyName(string name)
        {
            if (name.Equals(""))
            {
                return "El nombre es requerido.";
            }
            if (name.Any(c =>
            {
                int asciChar = (int)c;

                return (
                    char.IsNumber(c) || (asciChar != 32 && asciChar >= 65 && asciChar <= 90 && asciChar >= 97 && asciChar <= 122 && asciChar >= 160 && asciChar <= 165)
                );
            }))
            {
                return "El nombre solo puede tener letras.";
            }
            if (name.Length < 3 || name.Length > 30)
            {
                return "No puede ingresar un nombre con menos de 3 caracteres y más de 30 caracteres.";
            }

            if (name.Any(c =>
            {
                int asciChar = (int)c;

                return (
                    !char.IsNumber(c) && (asciChar == 32 || (asciChar >= 65 && asciChar <= 90) || (asciChar >= 97 && asciChar <= 122) || (asciChar >= 160 && asciChar <= 165))
                );
            }) && name.Length >= 3 && name.Length <= 30)
            {
                return $"¡El nombre {name} es correcto!";
            }
            throw new NotImplementedException();
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
            if (password.Length < 8 || password.Length > 15)
            {
                return "La contraseña no puede tener menos de 8 caracteres y más de 15 caracteres.";
            }
            if (password.Contains(" "))
            {
                return "La contraseña no debe contener espacios.";
            }
            if (!password.Any(c => char.IsLower(c)) || !password.Any(c => char.IsUpper(c)) || !password.Any(c => char.IsNumber(c)) || !password.Any(c =>
            {
                int asciChar = (int)c;

                return (
                    (asciChar >= 33 && asciChar <= 47) ||
                    (asciChar >= 58 && asciChar <= 64) ||
                    (asciChar >= 91 && asciChar <= 96) ||
                    (asciChar >= 123 && asciChar <= 126)
                );
            }))
            {
                return "La contraseña debe tener al menos una letra en minuscula, mayuscula, un número y un caracteres especial.";
            }

            if (!password.Equals("") && !Password.Equals(password) && password.Length >= 8 && password.Length <= 15 && !password.Contains(" ") && password.Any(c => char.IsLower(c)) && password.Any(c => char.IsUpper(c)) && password.Any(c => char.IsNumber(c)) && password.Any(c =>
            {
                int asciChar = (int)c;

                return (
                    (asciChar >= 33 && asciChar <= 47) ||
                    (asciChar >= 58 && asciChar <= 64) ||
                    (asciChar >= 91 && asciChar <= 96) ||
                    (asciChar >= 123 && asciChar <= 126)
                );
            }))
            {
                return "¡La password es correcta!";
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

            if (!email.Equals("") && new EmailAddressAttribute().IsValid(email))
            {
                return $"¡El Email {email} es correcto!";
            }
            throw new NotImplementedException();
        }
    }
}

