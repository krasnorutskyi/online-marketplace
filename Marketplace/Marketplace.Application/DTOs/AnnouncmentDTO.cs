namespace Marketplace.Application.DTOs;

public class AnnouncmentDTO
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public int Price { get; set; }
    
    public string Image { get; set; }
    
    public CategoryDTO Category { get; set; }
    
    public UserDTO Author { get; set; }
}