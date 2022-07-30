namespace Marketplace.Core.Entities;

public class Announcment : EntityBase
{
    public string Title { get; set; }
    
    public string Description { get; set; }
    
    public int Price { get; set; }
    
    public string Image { get; set; }
    
    public Category Category { get; set; }
    
    public User Author { get; set; }
    
}