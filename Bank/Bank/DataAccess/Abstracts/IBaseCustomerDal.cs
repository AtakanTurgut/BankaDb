using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DataAccess.Abstracts;
public interface IBaseCustomerDal
{
	List<BaseCustomer> GetAll();
	void Add(BaseCustomer customer);
}
