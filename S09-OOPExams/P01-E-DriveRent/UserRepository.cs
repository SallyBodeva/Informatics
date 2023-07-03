using EDriveRent.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace P01_E_DriveRent
{
    public class UserRepository : IRepository<User>
    {
        private readonly List<User> users;
        public UserRepository()
        {
            this.users = new List<User>();
        }
        public ReadOnlyCollection<User> Users
        {
            get { return this.users.AsReadOnly(); }
        }
        public void AddModel(User model)
        {
            this.users.Add(model);
        }

        public User FindById(string identifier)
        {
            return this.users.FirstOrDefault(x => x.DrivingLicenseNumber == identifier);
        }

        public IReadOnlyCollection<User> GetAll()
        {
            return Users;
        }

        public bool RemoveById(string identifier)
        {
            var u = this.users.FirstOrDefault(x => x.DrivingLicenseNumber == identifier);
            return this.users.Remove(u);
        }
    }
}
