//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ikeepfit.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class mt_articletype
    {
        public mt_articletype()
        {
            this.mt_article = new HashSet<mt_article>();
        }
    
        public string mt_articletype_id { get; set; }
        public string mt_articletype_name { get; set; }
    
        public virtual ICollection<mt_article> mt_article { get; set; }
    }
}
