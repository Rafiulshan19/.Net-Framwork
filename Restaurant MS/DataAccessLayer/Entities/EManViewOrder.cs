using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class EManViewOrder
    {
        
        public string FoodCategory
        {
            get;
            set;
        }
        public string FoodItem
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
    }
}
