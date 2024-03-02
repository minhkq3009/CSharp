using System;
using System.Collections.Generic;

// Định nghĩa lớp Drug để lưu trữ thông tin về thuốc
class Drug
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public Dictionary<string, int> Components { get; set; } // Danh sách các thành phần và số lượng (mg)

    public Drug(string name, int quantity, decimal price, string category)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
        Category = category;
        Components = new Dictionary<string, int>();
    }

    // Phương thức để hiển thị thông tin chi tiết về thuốc
    public void DisplayDetails()
    {
        Console.WriteLine($"Ten thuoc: {Name}");
        Console.WriteLine($"So luong: {Quantity}");
        Console.WriteLine($"Gia ban: {Price}");
        Console.WriteLine($"Danh muc: {Category}");
        Console.WriteLine("Cac thanh phan:");
        foreach (var component in Components)
        {
            Console.WriteLine($"{component.Key}: {component.Value} mg");
        }
    }
}
