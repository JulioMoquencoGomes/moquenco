namespace Repository;

using Domain;
using Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Infra.Data;

public abstract class RepositoryBase<TModel> : IDisposable, IRepositoryBase<TModel> where TModel : class
{
    private readonly ApplicationDbContext _context;
    public RepositoryBase(ApplicationDbContext context)
    {
        _context = context;
    }
    public virtual void Add(TModel obj)
    {
        _context.Set<TModel>().Add(obj);
        _context.SaveChanges();
    }
    public virtual TModel GetById(int id)
    {
        return _context.Set<TModel>().Find(id);
    }
    public virtual IList<TModel> GetAll()
    {
        return _context.Set<TModel>().ToList();
    }
    public virtual void Update(TModel obj)
    {
        _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        _context.SaveChanges();
    }
    public virtual void Remove(int id)
    {
        TModel? model = GetById(id);
        if(model != null)
        {
            _context.Set<TModel>().Remove(model);
            _context.SaveChanges();
        }
    }
    public void Dispose()
    {
        _context.Dispose();
    }
}