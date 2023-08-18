using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   public  class ItemType<T>: Category<T>
    {
        public T ItemId
        {
            get;
            set;
        }
        public string ItemName
        {
            get;
            set;
        }

        public string ItemPrice
        {
            get;
            set;
        }


    }

    public class Category<T>
    {
        public T CategoryId
        {
            get;
            set;
        }

        public string CategoryName
        {
            get;
            set;
        }

    }
}
