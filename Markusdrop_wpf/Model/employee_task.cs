//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Markusdrop_wpf.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class employee_task
    {
        public int id_employee_task { get; set; }
        public Nullable<int> id_employee_fk { get; set; }
        public Nullable<int> id_task_fk { get; set; }
        public Nullable<System.DateTime> task_completedate { get; set; }
    
        public virtual company_task company_task { get; set; }
        public virtual users users { get; set; }
    }
}
