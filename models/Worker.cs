namespace api.models;

public class Worker
{


    public int Id { get; set; }
    
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Position { get; set; }
    public string PositionType { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public int Warning { get; set; }
    public string Comment { get; set; }
    public bool IsRqth { get; set; }
    public int DayOff { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public bool IsCeo { get; set; }
    public bool IsRh { get; set; }
    public string Country { get; set; }
    public string Address { get; set; }
    public string Zip { get; set; }
    public string City { get; set; }
    public int? CompanyId { get; set; }
    public Company? Company { get; set; }
}