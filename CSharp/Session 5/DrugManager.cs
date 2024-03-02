using System;
using System.Collections.Generic;

// Lớp quản lý danh sách thuốc
class DrugManager
{
    private List<Drug> drugs = new List<Drug>();

    // Thêm thuốc mới
    public void AddDrug(Drug drug)
    {
        drugs.Add(drug);
    }

    // Hiển thị danh sách thuốc theo danh mục
    public void DisplayByCategory(string category)
    {
        foreach (var drug in drugs)
        {
            if (drug.Category == category)
            {
                Console.WriteLine($"{drug.Name} - Số lượng: {drug.Quantity} - Giá bán: {drug.Price}");
            }
        }
    }

    // Hiển thị thông tin chi tiết về thuốc
    public void DisplayDrugDetails(string name)
    {
        var drug = drugs.Find(d => d.Name == name);
        if (drug != null)
        {
            drug.DisplayDetails();
        }
        else
        {
            Console.WriteLine("Không tìm thấy thuốc.");
        }
    }

    // Tìm kiếm thuốc
    public void SearchDrug(string name)
    {
        var drug = drugs.Find(d => d.Name == name);
        if (drug != null)
        {
            drug.DisplayDetails();
        }
        else
        {
            Console.WriteLine("Không tìm thấy thuốc.");
        }
    }

    // Cập nhật thông tin thuốc
    public void UpdateDrug(string name, int quantity, decimal price)
    {
        var drug = drugs.Find(d => d.Name == name);
        if (drug != null)
        {
            drug.Quantity = quantity;
            drug.Price = price;
            Console.WriteLine("Thông tin thuốc đã được cập nhật.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy thuốc.");
        }
    }

    // Xóa thuốc
    public void RemoveDrug(string name)
    {
        var drug = drugs.Find(d => d.Name == name);
        if (drug != null)
        {
            drugs.Remove(drug);
            Console.WriteLine("Thuốc đã được xóa khỏi danh sách.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy thuốc.");
        }
    }
}
