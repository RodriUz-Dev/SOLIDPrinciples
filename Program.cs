using SOLIDPrinciples.DependencyInversionPrinciple;
using SOLIDPrinciples.InterfaceSegregationPrinciple;
using SOLIDPrinciples.LiskovSubstitutionPrinciple;
using SOLIDPrinciples.OpenClosePrinciple;
using SOLIDPrinciples.SingleResponsibilityPrinciple;

// Main program to demonstrate the use of the ProductService with a repository and discount strategy
// This program creates a product repository, adds products to it, and applies a discount strategy to calculate discounted prices.

var repository = new ProductRepository();
// Adding products to the repository
// This follows the Single Responsibility Principle by keeping product management separate from discount logic.
repository.AddProduct(new Product { Id = 1, Name = "Laptop", Price = 1000m });
repository.AddProduct(new Product { Id = 2, Name = "Smartphone", Price = 500m });

// Creating a discount strategy
// This follows the Open/Closed Principle by allowing new discount strategies to be added without modifying existing code.
var discount1 = new PercentageDiscount(10); // 10% discount

// Creating a product service with the repository and discount strategy
// This service will be used to get discounted prices for products
// This follows the Liskov Substitution Principle by allowing different discount strategies to be used interchangeably.
var productService = new ProductService(repository, discount1);

// Iterating through all products in the repository
// This demonstrates the use of the ProductService to get discounted prices for each product.
// This follows the Single Responsibility Principle by keeping the product retrieval and discount calculation logic separate.
foreach (var product in repository.GetAllProducts())
{
    // Getting the discounted price for each product
    // This demonstrates the Liskov Substitution Principle by using the discount strategy to apply discounts.
    var discountedPrice = productService.GetDiscountedPrice(product);
    Console.WriteLine($"Product: {product.Name}, Original Price: {product.Price:C}, Discounted Price: {discountedPrice:C}");
}

// Adding another discount strategy to demonstrate the Open/Closed Principle
// This allows the program to use different discount strategies without changing the existing code.
// Here, we create a new discount strategy that does not apply any discount. 
var discount2 = new NoDiscount(); // No discount strategy
productService = new ProductService(repository, discount2);
// Iterating through all products in the repository with no discount
foreach (var product in repository.GetAllProducts())
{
    // Getting the discounted price for each product
    var discountedPrice = productService.GetDiscountedPrice(product);
    Console.WriteLine($"Product: {product.Name}, Original Price: {product.Price:C}, Discounted Price: {discountedPrice:C}");
}


var printer = new ConsolePrinter();
var emailSender = new EmailSender();
var notificationService = new NotificationService(emailSender, printer);
// Sending a notification using the NotificationService
notificationService.Notify("testclient@example.com", "Purchase Confirmation", "Your order has been successfully placed.");
