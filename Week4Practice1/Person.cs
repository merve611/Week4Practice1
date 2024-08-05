using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Practice1
{
    public class Person                                             //person adında bir class tanımladım ve istenen property leri kullandım
    {
        public string name;
        public string lastname;
        public DateTime dateofBirth;






        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string LastName 
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public DateTime DateofBirth 
        {
            get
            {
                return dateofBirth;
            }
            set 
            {
                dateofBirth = value;

            }
        }


        public void InfoPerson()
        {
            Console.WriteLine("İsim : " + name + "Soyisim : "+ " " + lastname + " " + "Doğum tarihi : " + dateofBirth );
        }
    }
}
