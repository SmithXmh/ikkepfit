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
    
    public partial class mt_course_day
    {
        public string mt_course_id { get; set; }
        public string mt_courseday_id { get; set; }
        public string mt_courseday_name { get; set; }
        public string mt_courseday_count { get; set; }
        public string mt_courseday_time { get; set; }
        public string mt_courseday_kcalorie { get; set; }
        public string mt_courseday_video { get; set; }
    
        public virtual mt_course mt_course { get; set; }
    }
}
