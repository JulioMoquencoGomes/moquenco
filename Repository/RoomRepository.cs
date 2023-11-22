namespace Repository;

using Domain;
using Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Infra.Data;

public abstract class RoomRepository
{
    protected readonly ApplicationDbContext _context;

    public RoomRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Room GetById(int id)
    {
        return _context.Set<Room>().Where(p=>p.Id == id).FirstOrDefault();
    }

    public List<Room> GetAllByUserId(string user_id)
    {
        //return _context.Set<Room>().Where(p=>p.UserRooms.UserId == user_id).ToList();
        return _context.Set<Room>().ToList();
    }

    public void Add(Room model)
    {
        _context.Set<Room>().Add(model);
        _context.SaveChanges();
    }

    public void Update(Room model)
    {
        _context.Set<Room>().Update(model);
        _context.SaveChanges();
    }

    public void Remove(Room model)
    {
       _context.Set<Room>().Remove(model);
    }

}
