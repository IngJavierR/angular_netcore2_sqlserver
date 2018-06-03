using Microsoft.Extensions.Logging;
using Quiniela.Data;
using Quiniela.Models;

namespace Quiniela.Dao.DaoImpl
{
    public class UserDAO : BaseDAO<UserDO>, IUserDAO
    {
        public UserDAO(QuinielaContext context, ILogger<UserDO> logger) : base(context, logger)
        {
        }
    }
}
