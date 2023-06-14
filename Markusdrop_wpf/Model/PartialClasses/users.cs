using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markusdrop_wpf.Model
{
    public partial class users
    {
        public string FLP
        {
            get
            {
                return $"{first_name} {patronimyc} {last_name}";
            }
            set
            {
                this.FLP = value;
            }
        }
    }
}
