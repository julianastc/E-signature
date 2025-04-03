namespace Domain.Entities;

public class Document
{
    public int Id { get; set; }
    public int CreatorId { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
    public string File { get; set; }    
}