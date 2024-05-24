namespace atelier2.Models.Repositories
{
    public interface IRepository<T>
    {
        T Get(int id);
        IEnumerable <T> GetAll();
        T Add(T t);
        T Update(T t);
        T Delete(int id);
        List<T> Search(string term);

    }
}
