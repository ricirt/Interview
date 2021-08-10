using Business.Abstract;
using Business.Caching;
using DataAccess.Abstract;
using Entity;
using Entity.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IBranchService _branchService;
        ICacheService _cacheService;

        public UserManager(IUserDal userDal, IBranchService branchService,ICacheService cacheService)
        {
            _branchService = branchService;
            _userDal = userDal;
            _cacheService = cacheService;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
            _cacheService.Remove("Users.GetAll");
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
            _cacheService.Remove("Users.UserList");
        }

        public List<User> GetAll()
        {
            if (_cacheService.Any("Users.GetAll"))
            {
                var users = _cacheService.Get<List<User>>("Users.GetAll");
                return users;
            }
            var usersCached= _userDal.GetAll();
            _cacheService.Add("Users.GetAll", usersCached);
            return usersCached;
        }

        public User GetById(int id)
        {
            return _userDal.Get(u => u.UserId == id);
        }

        public List<UsersWtihLocation> GetUsersWtihLocations()
        {
            if(_cacheService.Any("Users.GetUsersWithLocations"))
            {
                var users = _cacheService.Get<List<UsersWtihLocation>>("Users.GetUsersWithLocations");
                return users;
            }
            var usersCached = _userDal.GetUsersWtihLocations();
            _cacheService.Add("Users.GetUsersWithLocations", usersCached);
            return usersCached;
        }

        public void Update(User user)
        {
            _userDal.Update(user);
            _cacheService.Remove("Users.UserList");
        }
        public List<Branch> GetBranches()
        {
            if (_cacheService.Any("Users.GetBranches"))
            {
                var users = _cacheService.Get<List<Branch>>("Users.GetBranches");
                return users;
            }
            var usersCached = _branchService.GetAll();
            _cacheService.Add("Users.GetBranches", usersCached);
            return usersCached;
        }
    }
}
