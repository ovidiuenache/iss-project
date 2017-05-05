using System;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Abstract Class AbstractUser
    /// Author: Ioan Ovidiu Enache
    /// 
    /// </summary>
    public abstract class AbstractUser : IUser
    {
        protected int id;
        protected string firstName;
        protected string lastName;
        protected DateTime birthdate;
        protected string telephone;
        protected string email;
        protected string password;
        protected string address;
        protected string city;
        protected string country;

        public string getAddress()
        {
            return address;
        }

        public DateTime getBirthdate()
        {
            return birthdate;
        }

        public string getCity()
        {
            return city;
        }

        public string getCountry()
        {
            return country;
        }

        public string getEmail()
        {
            return email;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getPassword()
        {
            return password;
        }

        public string getTelephone()
        {
            return telephone;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public void setBirthdate(DateTime birthdate)
        {
            this.birthdate = birthdate;
        }

        public void setCity(string city)
        {
            this.city = city;
        }

        public void setCountry(string country)
        {
            this.country = country;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setTelephone(string telephone)
        {
            this.telephone = telephone;
        }

        public int getId()
        {
            return id;
        }

        public override bool Equals(object obj)
        {
            var item = obj as AbstractUser;

            if (item == null)
            {
                return false;
            }

            return id == item.getId();
        }
    }
}
