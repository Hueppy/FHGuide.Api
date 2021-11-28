namespace FHGuide.Shared.Models;

public partial class RatingValue
{
    public int RatingValueId { get; set; }
    public string Categorie { get; set; } = null!;
    public int Value { get; set; }
    public string Text { get; set; } = null!;
    public int RatingId { get; set; }

    public virtual Rating Rating { get; set; } = null!;
}
