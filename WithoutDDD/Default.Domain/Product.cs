namespace Default.Domain;

public class Product
{
  public int Id { get; set; }
  // Product description
  public string? ProductName { get; set; }
  public string? ProductDescription { get; set; }
  public List<ProductCategory> Categories { get; set; } = new();

  // Bounded Context: Pricing
  public decimal PriceWithoutVAT { get; set; }
  public int VATPercentage { get; set; }
  public decimal VATValue { get; set; }
  public decimal PriceIncludingVAT { get; set; }

  // Bounded Context: Inventory
  public int QuantityOnHand { get; set; }
  public int RestockThreshold { get; set; }
  public string? ProductCode { get; set; }

  // Bounded Context: Reviews
  public List<Review> Reviews { get; set; } = new();
  public double ReviewAverage { get; set; }
}