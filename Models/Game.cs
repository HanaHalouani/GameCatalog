using System.ComponentModel.DataAnnotations;

namespace GameCatalog.Models;

public class Game
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Genre { get; set; }
    [Required]
    [Range(1, 100)]
    public decimal Price { get; set; }
    [Required]
    public DateTime ReleaseDate { get; set; }
}