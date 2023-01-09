using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDao _userDao;

        public UserManager(IUserDao userDao)
        {
            _userDao = userDao;
        }

        public IResult AddUser(User user)
        {
            _userDao.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult DeleteUser(User user)
        {
            _userDao.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public List<OperationClaim> GetOperationClaims(User user)
        {
            return _userDao.GetOperationClaims(user);
        }

        public List<OperationClaim> GetOperationClaims()
        {
            return _userDao.GetOperationClaims();
        }

        public User GetUserByEmail(string email)
        {
            return _userDao.Get(u => u.Email == email);
        }

        public IDataResult<List<User>> GetUsers()
        {
            return new SuccessDataResult<List<User>>(_userDao.GetList().ToList());
        }

        public IResult UpdateUser(User user)
        {
            _userDao.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }


    }
}
