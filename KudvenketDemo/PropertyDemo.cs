using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KudvenketDemo
{
  public class PropertyDemo
    {
        private int id;
        private string name;

        public int Id
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("id is not negative");
                }
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }


        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name is not null");
                }
                this.name = value;
            }
            get
            {
                return this.name;
            }


        }



    }



}
