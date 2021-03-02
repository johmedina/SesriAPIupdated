using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Threading.Tasks;
using SesriCatiApi.Entities;
using SesriCatiApi.Helpers;

namespace SesriCatiApi.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
        Task<IEnumerable<User>> GetAll();
        bool ValidateCredentials(string username, string password);
        Principal AuthWithAD(string username, string password);
    }

    public class UserService : IUserService
    {
        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        private List<User> _users = new List<User>
        {
            new User { Id = 1, FirstName = "Test", LastName = "User", Username = "test", Password = "test" },
        };

        // Authenticate returns a User with format defined in entities 
        public async Task<User> Authenticate(string username, string password)
        {
            var user = await Task.Run(() => _users.SingleOrDefault(x => x.Username == username && x.Password == password));

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so return user details without password
            return user.WithoutPassword();
        }

        public Principal AuthWithAD(string username, string password)
        {
            try
            {
                using (var adContext = new PrincipalContext(ContextType.Domain, "Quad"))
                {
                    bool isValid = false;
                    //Creates a connection to the server and returns a bool if valid or not
                    isValid = adContext.ValidateCredentials(username, password);
                    if (isValid == true)
                    {
                        var u = new UserPrincipal(adContext);
                        u.UserPrincipalName = username + "@qu.edu.qa";
                        var ps = new PrincipalSearcher();
                        ps.QueryFilter = u;
                        //PrincipalSearchResult<Principal> result = ps.FindAll();
                        Principal result = ps.FindOne();
                        Console.WriteLine("user test: " + result.UserPrincipalName);
                        Console.WriteLine();

                        return result;
                    }

                    else
                    {
                        Console.WriteLine("logged in user: not found");
                        Console.WriteLine();
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Code for authenticating using system.directoryservices
        public bool ValidateCredentials(string username, string password)
        {
            try 
            {
                using (var adContext = new PrincipalContext(ContextType.Domain, "Quad"))
                {
                    //Creates a connection to the server and returns a bool if valid or not
                    return adContext.ValidateCredentials(username, password);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await Task.Run(() => _users.WithoutPasswords());
        }

    }
}