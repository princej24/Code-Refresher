using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Code_Refresher
{
     public class Player
    {
        public string Name { get; set; }
        public int Number { get; set; }
       
        public override string ToString()
        {
            return $"{GetType().Name} - {Name} - Account Number: {Number}";

        }




        
    


    }
}
