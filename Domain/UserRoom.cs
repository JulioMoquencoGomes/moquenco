namespace Domain;

public class UserRoom
{
    public int Id { get; set; }
    public string Description { get; set; }

    public int RoomId { get; set; }
    public virtual Room Room { get; set; }

    public string UserId { get; set; }
}
