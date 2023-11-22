namespace Repository.Interfaces;

using Repository;
using Domain;

public interface IRoomRepository
{
    Room GetById(int id);
    List<Room> GetAllByUserId(int user_id);
    void Add();
    void Update();
    void Remove();
}