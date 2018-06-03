using AutoMapper;
using Microsoft.Extensions.Logging;
using Quiniela.Dao;
using Quiniela.TO;

namespace Quiniela.Services
{
    public class QuinielaService : IQuinielaServices
    {
        private readonly ILogger _logger;
        private IUserDAO _userDAO;
        private IMapper _mapper;

        public QuinielaService(IUserDAO userDAO, IMapper mapper, ILogger<QuinielaService> logger){
            this._logger = logger;
            this._userDAO = userDAO;
            this._mapper = mapper;
        }

        public UserTO GetUser(long id)
        {
            var user = this._userDAO.FindElementById(id);
            return this._mapper.Map<UserTO>(user);
        }
    }
}
