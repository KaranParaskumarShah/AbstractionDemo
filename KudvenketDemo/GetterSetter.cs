using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KudvenketDemo
{
   public  class GetterSetter
    {
        private string firstName;
        
        private int id;
        public int marks;

        public void SetFirstName(string Fname)
        {
            if (string.IsNullOrEmpty(Fname))
            {
                throw new Exception("This is null please reenter your name");
            }

            this.firstName = Fname;
        }

        public void SetId(int Id)
        {
            if (Id < 0)
            {
                throw new Exception("id not negative");
            }
            this.id = Id;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }


    }





}
