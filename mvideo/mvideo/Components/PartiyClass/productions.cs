using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvideo.Components
{
    public partial class production
    {
        public string Names
        {
            get
            {
                return App.db.Products.Where(x => x.Id == id_prods).Select(x => x.Title).ToString();
            }
        }
        public string chena
        {
            get
            {
                return App.db.Products.Where(x => x.Id == id_prods).Select(x => x.Cost).ToString();
            }
        }
        public string summa
        {
            get
            {
                return null;
                //return (App.db.Products.Where(x => x.Id == id_prods).Select(x => x.Cost) * (decimal)col);
            }
        }
    }
}
