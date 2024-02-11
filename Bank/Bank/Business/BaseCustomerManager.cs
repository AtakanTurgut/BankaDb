using Bank.DataAccess.Abstracts;
using Bank.DataAccess.Concretes;
using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Business
{
	public class BaseCustomerManager
	{
		private readonly IBaseCustomerDal _customerDal;

		public BaseCustomerManager(IBaseCustomerDal customerDal)
		{
			_customerDal = customerDal;
		}

		public List<BaseCustomer> GetAll()
		{
			// business rules

			return _customerDal.GetAll();
		}

	}
}
