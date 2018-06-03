namespace Quiniela.Dao
{
    public interface IBaseDAO<T> where T : class
    {
        T FindElementById(long id);
        T Save(T toSave);
        T Replace(T toReplace);
        T Delete(T toDelete);
    }
}
