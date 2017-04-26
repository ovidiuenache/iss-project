using System;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Interface IUser
    /// Author: Ioan Ovidiu Enache
    /// 
    /// </summary>
    public interface IUser
    {
        int getId();
        string getFirstName();
        void setFirstName(string firstName);
        string getLastName();
        void setLastName(string lastName);
        DateTime getBirthdate();
        void setBirthdate(DateTime birthdate);
        string getTelephone();
        void setTelephone(string telephone);
        string getEmail();
        void setEmail(string email);
        string getPassword();
        void setPassword(string password);
        string getAddress();
        void setAddress(string address);
        string getCity();
        void setCity(string city);
        string getCountry();
        void setCountry(string country);
    }
}
