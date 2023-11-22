namespace Domain;

public class Room
{
    public int Id { get; set; }
    public string Description { get; set; }

    public List<UserRoom> UserRooms { get; set; }
}
