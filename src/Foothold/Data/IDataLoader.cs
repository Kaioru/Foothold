namespace Foothold.Data;

public interface IDataLoader<T> where T : IData
{
    T Load(int id);
}