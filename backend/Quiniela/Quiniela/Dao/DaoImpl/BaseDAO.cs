using Microsoft.Extensions.Logging;
using Quiniela.Data;

namespace Quiniela.Dao.DaoImpl
{
    public abstract class BaseDAO<T> : IBaseDAO<T> where T : class
    {
        protected readonly QuinielaContext _context;
        protected readonly ILogger _logger;

        public BaseDAO(QuinielaContext context, ILogger<T> logger)
        {
            this._context = context;
            this._logger = logger;
        }

        public T FindElementById(long id) {
            return this._context.Find<T>(id);
        }

        public T Save(T toSave) {
            this._context.Add(toSave);
            return toSave;
        }

        public T Replace(T toReplace) {
            this._context.Update(toReplace);
            return toReplace;
        }

        public T Delete(T toDelete)
        {
            this._context.Remove(toDelete);
            return toDelete;
        }
    }
}
