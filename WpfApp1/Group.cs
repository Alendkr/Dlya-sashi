//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Group
    {
        public decimal ID { get; set; }
        public decimal Year { get; set; }
        public string Literal { get; set; }
        public decimal SubGroup { get; set; }
        public decimal CountClasses { get; set; }
        public string Name { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
