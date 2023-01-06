using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetOperationClaims(User user);
        List<OperationClaim> GetOperationClaims();

        User GetUserByEmail(string email);
        IDataResult<List<User>> GetUsers();

        IResult AddUser(User user);
        IResult DeleteUser(User user);
        IResult UpdateUser(User user);
    }
}
