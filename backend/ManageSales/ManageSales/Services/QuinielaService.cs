using Microsoft.Extensions.Logging;
using Quiniela.Dao;
using Quiniela.TO;

namespace Quiniela.Services
{
    public class QuinielaService : IQuinielaServices
    {
        private readonly ILogger _logger;
        private IUserDAO _userDAO;

        public QuinielaService(IUserDAO userDAO, ILogger<QuinielaService> logger){
            this._logger = logger;
            this._userDAO = userDAO;
        }

        public UserTO GetUser(long id)
        {
            var user = this._userDAO.FindElementById(id);

            return new UserTO();
        }
    }
}
