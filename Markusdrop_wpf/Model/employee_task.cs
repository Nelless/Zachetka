//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Markusdrop_wpf.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class employee_task
    {
        public int id_employee_task { get; set; }
        public Nullable<int> employee_id { get; set; }
        public Nullable<int> task_id { get; set; }
    
        public virtual company_task company_task { get; set; }
        public virtual users users { get; set; }
    }
}