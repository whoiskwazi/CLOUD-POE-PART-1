namespace KhumaloCraft.Models;

public class ErrorViewModel
{
    

    public string? RequestId { get; set; }

    public int Id { get; set; }
    public string? Title { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
     
    
}

