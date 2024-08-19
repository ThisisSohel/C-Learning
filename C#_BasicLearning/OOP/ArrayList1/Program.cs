
using ArrayList1;
using System.Collections;

Customer customer1 = new Customer()
{
    Id = 1,
    Name = "Sakib",
    Salary = 2000
};
Customer customer2 = new Customer()
{
    Id = 11,
    Name = "Suny",
    Salary = 3000
};
Customer customer3 = new Customer()
{
    Id = 12,
    Name = "Rakib",
    Salary = 1000
};

ArrayList arrayList = new ArrayList();

arrayList.Add(customer1);
arrayList.Add(customer2);
arrayList.Add(customer3);
arrayList.Insert(0, customer2);
arrayList.InsertRange(1, arrayList);
arrayList.RemoveAt(0);
Customer c = (Customer)arrayList[0];
c.Name = "sjgf";
//arrayList[0].Name = "DDDD";
foreach (Customer aList in arrayList)
{
    Console.WriteLine("Id = {0} Name {1} Salary {2}", aList.Id, aList.Name, aList.Salary);

}
