//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvideo.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class production
    {
        public int id { get; set; }
        public int id_zakaz { get; set; }
        public int id_prods { get; set; }
        public Nullable<int> col { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Zakaz Zakaz { get; set; }
    }
}
