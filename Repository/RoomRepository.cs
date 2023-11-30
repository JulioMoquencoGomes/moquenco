namespace Repository;

using Domain;
using Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Infra.Data;
using System.Collections.Generic;

public class RoomRepository : RepositoryBase<Room>, IRoomRepository
{

    public RoomRepository(ApplicationDbContext context) : base (context)
    {}
}
