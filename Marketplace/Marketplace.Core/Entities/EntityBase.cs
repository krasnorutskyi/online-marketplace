using System.ComponentModel.DataAnnotations;
namespace Marketplace.Core.Entities;

public class EntityBase
{
    [Key] 
    public int Id { get; set; }
    
}