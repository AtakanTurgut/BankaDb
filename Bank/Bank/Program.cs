using Bank.Entities;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678910";
customer1.FirstName = "Atakan";
customer1.LastName = "Turgut";
customer1.CustomerNumber = "147369";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "1987654321";
customer2.FirstName = "Furkan";
customer2.LastName = "Üvenç";
customer2.CustomerNumber = "741963";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "ABC";
customer3.CustomerNumber = "159263478";
customer3.TaxNumber = "321";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "XYZ";
customer4.CustomerNumber = "874632951";
customer4.TaxNumber = "123";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

// Polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.Id);
    Console.WriteLine(customer.CustomerNumber);
	Console.WriteLine(new string('-', 10));
}