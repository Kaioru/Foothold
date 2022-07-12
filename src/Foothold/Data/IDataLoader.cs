namespace Foothold.Data;

public interface IDataLoader<T> where T : IData
{
    Task<T> Load(int id);
}