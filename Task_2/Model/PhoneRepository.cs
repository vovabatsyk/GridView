using System.Collections.ObjectModel;

namespace Task_2.Model
{
    class PhoneRepository: ObservableCollection<Phone>
    {
        public PhoneRepository()
        {
            this.Add(new Phone() { Title = "iPhone 11", Company = "Apple", Price = "21999", Description = "Apple iPhone 11 64Gb Black" });
            this.Add(new Phone() { Title = "Galaxy A31", Company = "Samsung", Price = "5999", Description = "Samsung Galaxy A31 4/128Gb Prism Crush Black (SM-A315FZKVSEK)" });
            this.Add(new Phone() { Title = "Redmi Note 9", Company = "Xiaomi", Price = "5299", Description = "Xiaomi Redmi Note 9 4/128GB Midnight Grey" });
            this.Add(new Phone() { Title = "Galaxy S21 Ultra", Company = "Samsung", Price = "37999", Description = "Samsung Galaxy S21 Ultra 12/128Gb Phantom Black (SM-G998BZKDSEK)" });
            this.Add(new Phone() { Title = "iPhone 12 Pro Max", Company = "Apple", Price = "8000", Description = "Apple iPhone 12 Pro Max 128Gb Pacific Blue" });
        }
    }
}
