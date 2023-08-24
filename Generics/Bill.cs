using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Bill<T, V> : Base<T, V>, Client<T, V>, ItemType<T, V>, Category<T, V>
    {
       public T ItemId { get; set; }
        public string ClientName { get; set; }
        public string ClientNumber { get; set; }
        public string ClientEmail { get; set; }
        public string ClientPassword { get; set; }

        public DateTime ClientDOB { get; set; }

        public T GenderId { get; set; }

        public T Id { get; set; }

        public V CreatedOn { get; set; }

        public string ClientGenderName { get; set; }


        public T Operation { get; set; }


        public string OperationName { get; set; }

        public string ItemName { get; set; }

        public int ItemPrice { get; set; }

        public string CategoryName { get; set; }

        public int ItemQuantity { get; set; }
        
        public T PaymentId { get; set; }
        public string PaymentTypeName { get; set; }
        public T CategoryId { get; set; }
        
        public T ClientId { get; set; }

        public int TotalBill { get; set; }

        public int TotalCategoryQuantity
        {
            get;set;
        }
    }
}
