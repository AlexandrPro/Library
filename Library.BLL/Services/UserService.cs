using Library.DAL.EF;
using Library.DAL.Repository;
using Library.Entities;
using Library.ViewModel.User;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.BLL.Services
{
    public class UserService
    {
        LibraryContext db;
        UserRepository userRepository;

        public UserService()
        {
            db = new LibraryContext();
            userRepository = new UserRepository(db);
        }

        public void Create(CreateUserViewModel item)
        {
            //TODO: validation
            User user = new User //TODO: automaper
            {
                Id = Guid.NewGuid(),
                CreationDate = DateTime.Now,
                Name = item.Name,
                Password = item.Password
            };
            userRepository.Create(user);
        }

        public bool isUserCorrect(LoginUserViewModel item)
        {
            User user = userRepository.Find(u => u.Name == item.Name && u.Password == item.Password).FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isLoginUnoccupied(string login)
        {
            User user = userRepository.Find(u => u.Name == login && u.Password == login).FirstOrDefault();
            if (user == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
