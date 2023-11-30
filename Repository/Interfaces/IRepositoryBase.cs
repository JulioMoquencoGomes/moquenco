namespace Repository.Interfaces;
using System.Collections.Generic;
public interface IRepositoryBase<TModel> where TModel : class
{
    void Add(TModel obj);

    TModel GetById(int id);

    IList<TModel> GetAll();

    void Update(TModel obj);

    void Remove(int id);

    void Dispose();
}