//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ikeepfit.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class mt_mark
    {
        public mt_mark()
        {
            this.mt_knowledgemark = new HashSet<mt_knowledgemark>();
            this.mt_planmark = new HashSet<mt_planmark>();
        }
    
        public string mt_mark_id { get; set; }
        public string mt_mark_name { get; set; }
    
        public virtual ICollection<mt_knowledgemark> mt_knowledgemark { get; set; }
        public virtual ICollection<mt_planmark> mt_planmark { get; set; }
    }
}