using Bank.DataAccess.Abstracts;
using Bank.Entities;

namespace Bank.DataAccess.Concretes
{
	public class EfBaseCustomerDal : IBaseCustomerDal
	{
		List<BaseCustomer> customers;

		public EfBaseCustomerDal()
		{
			IndividualCustomer customer1 = new IndividualCustomer();
			customer1.Id = 5;
			customer1.NationalIdentity = "1595487362";
			customer1.FirstName = "Yağmur";
			customer1.LastName = "Soydan";
			customer1.CustomerNumber = "894565123";

			IndividualCustomer customer2 = new IndividualCustomer();
			customer2.Id = 6;
			customer2.NationalIdentity = "897546213";
			customer2.FirstName = "Talat";
			customer2.LastName = "Akkaleli";
			customer2.CustomerNumber = "14923874";

			CorporateCustomer customer3 = new CorporateCustomer();
			customer3.Id = 7;
			customer3.Name = "FGH";
			customer3.CustomerNumber = "3579842316";
			customer3.TaxNumber = "852";

			CorporateCustomer customer4 = new CorporateCustomer();
			customer4.Id = 8;
			customer4.Name = "QWE";
			customer4.CustomerNumber = "6897412";
			customer4.TaxNumber = "456";

			customers = new List<BaseCustomer> { customer1, customer2, customer3, customer4 };
		}

		public List<BaseCustomer> GetAll()
		{
			return customers;
		}

		public void Add(BaseCustomer customer)
		{
			customers.Add(customer);
		}
	}
}


