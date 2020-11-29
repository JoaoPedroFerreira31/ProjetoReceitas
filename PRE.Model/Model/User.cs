using PRE.Model.Model.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE.Model.Model
{
    public class User
    {
        public int IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; } // Enum
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public bool Blocked { get; set; }

        public Account Account { get; set; }        
        public List<Recipe> OwnRecipies { get; set; }
        public List<Recipe> FavoriteRecipies { get; set; }

        //Create Override Method
        public override string ToString()
        {
            return $"ID: {IdUser}, {FirstName}, {LastName}, {BirthDate.ToShortDateString()}, {Gender}, {Email}, IsAdmin: {IsAdmin}, Blocked: {Blocked}, Account: {Account.Username}";
        }

        //Create builders to generate users
        public User()
        {
        }

        public User(int idUser, string firstName, string lastName, DateTime birthDate, Gender gender, string email, bool isAdmin, bool blocked , Account account, List<Recipe> ownRecipies, List<Recipe> favoriteRecipies)
        {
            IdUser = idUser;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            Email = email;
            IsAdmin = isAdmin;
            Blocked = blocked;
            Account = account;
            OwnRecipies = ownRecipies;
            FavoriteRecipies = favoriteRecipies;
        }

        public User(int idUser, string firstName, string lastName, DateTime birthDate, string email, bool isAdmin, bool blocked, Account account)
        {
            IdUser = idUser;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Email = email;
            Blocked = blocked;
            Account = account;
            IsAdmin = isAdmin;
        }

        public User(string firstName, string lastName, DateTime birthDate, Gender gender, string email)
        {
            FirstName = firstName;
            LastName = lastName; 
            BirthDate = birthDate;
            Gender = gender;
            Email = email; 
        }

        public User(string firstName, string lastName, DateTime birthDate, Gender gender, string email, bool isAdmin)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            Email = email;
            IsAdmin = isAdmin;
        }

        public User(string firstName, string lastName, DateTime birthDate, Gender gender, string email, bool isAdmin, bool blocked)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            Email = email;
            IsAdmin = isAdmin;
            Blocked = blocked;
        }
    }
}

