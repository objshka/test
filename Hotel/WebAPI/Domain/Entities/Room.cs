namespace WebAPI.Domain.Entities;

public class Room
{
    public int Id { get; set; }
    public int HotelId { get; set; }
    public int Number { get; set; }
    public decimal Price { get; set; }
    public bool IsOccupied { get; set; }
    public Hotel Hotel { get; set; }
}