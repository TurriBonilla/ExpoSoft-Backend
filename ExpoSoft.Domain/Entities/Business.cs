using ExpoSoft.Domain.Base;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ExpoSoft.Domain.Entities
{
    public class Business : Entity<int>, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Nit { get; private set; }
        public string Email { get; private set; }
        [JsonIgnore]
        public string Password { get; private set; }
        public string TypeOfBusiness { get; private set; }
        public string Department { get; private set; }
        public string Town { get; private set; }
        public string OwnerName { get; private set; }
        public string OwnerlastName { get; private set; }
        [JsonIgnore]
        public Score Score { get; private set; }
        [JsonIgnore]
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

        public string SignUp(string name, string nit, string email, string password)
        {
            Nit = nit;
            var resName = ModifyName(name);
            if (resName.Equals($"¡El nombre {name} es correcto!"))
            {
                var resEmail = ModifyEmail(email);
                if(resEmail.Equals($"¡El Email {email} es correcto!"))
                {
                    var resPass = ModifyPassword(password);
                    if (resPass.Equals("¡La password es correcta!"))
                    {
                        return "Registro Exitoso.";
                    }
                    return resPass;
                }
                return resEmail;
            }
            return resName;

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
                Name = name;
                return $"¡El nombre {Name} es correcto!";
            }
            throw new NotImplementedException();
        }
        public string ModifyPassword(string password)
        {
            if (password.Equals(""))
            {
                return "No puede ingresar una contraseña vacia.";
            }
            if (password.Equals(Password))
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

            if (!password.Equals("") && !password.Equals(Password) && password.Length >= 8 && password.Length <= 15 && !password.Contains(" ") && password.Any(c => char.IsLower(c)) && password.Any(c => char.IsUpper(c)) && password.Any(c => char.IsNumber(c)) && password.Any(c =>
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
                Password = password;
                return "¡La password es correcta!";
            }

            throw new NotImplementedException();
        }
        public string ModifyPhoneNumber(string phoneNumber)
        {
            if (!phoneNumber.Length.Equals(10))
            {
                return "El número celular debe tener 10 digitos.";
            }
            if (phoneNumber.Any(c => !char.IsNumber(c)))
            {
                return "El número celular solo puede contener números.";
            }

            if (phoneNumber.Length.Equals(10) && phoneNumber.Any(c => char.IsNumber(c)))
            {
                return $"¡El número telefonico {phoneNumber} es correcto!";
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
                Email = email;
                return $"¡El Email {Email} es correcto!";
            }
            throw new NotImplementedException();
        }
    }
}

