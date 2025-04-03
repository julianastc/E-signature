namespace Domain.Entities;

public class Signature
{
    public int Id { get; set; }
    public int DocumentId { get; set; }
    public string SignatoryEmail { get; set; }
    public DateTime DateOfSignature { get; set; }
}