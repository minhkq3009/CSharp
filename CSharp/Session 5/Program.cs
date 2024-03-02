using System;

class Program
{
    static void Main(string[] args)
    {
        DrugManager manager = new DrugManager();

        // Thêm một số thuốc mẫu
        manager.AddDrug(new Drug("Paracetamol", 100, 10.5m, "Thuốc đau"));
        manager.AddDrug(new Drug("Amoxicillin", 50, 20.3m, "Thuốc kháng sinh"));
        //...

        // Sử dụng các phương thức để thực hiện chức năng
        manager.DisplayByCategory("Thuốc đau");
        manager.DisplayDrugDetails("Paracetamol");
        manager.SearchDrug("Amoxicillin");
        manager.UpdateDrug("Paracetamol", 90, 11.2m);
        manager.RemoveDrug("Amoxicillin");
    }
}

