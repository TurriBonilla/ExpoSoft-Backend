using ExpoSoft.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (Password == password)
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
            if(password.Contains(" "))
            {
                return "La contraseña no debe contener espacios.";
            }
            throw new NotImplementedException();
        }
    }
}
