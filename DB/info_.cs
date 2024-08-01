using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineInfo.DB
{ 
    public class Question
    {
        private string Name;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        private string Pro_name;
        public string pro_name
        {
            get { return Pro_name; }
            set { Pro_name = value; }
        }

        private string Effect;

        public string effect
        {
            get { return Effect; }
            set { Effect = value; }
        }
    }

}
