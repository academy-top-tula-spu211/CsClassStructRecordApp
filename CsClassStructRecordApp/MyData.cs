using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsClassStructRecordApp
{
    struct MyData
    {
        public string name;
        public int age;

        public MyData() 
        {
            this.name = "";
            this.age = 0;
        }

        public MyData(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    record MyRecData
    {
        public string name;
        public int age;

        public MyRecData()
        {
            this.name = "";
            this.age = 0;
        }

        public MyRecData(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

}
