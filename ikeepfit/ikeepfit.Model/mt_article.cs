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
    
    public partial class mt_article
    {
        public string mt_articletype_id { get; set; }
        public string mt_article_id { get; set; }
        public string mt_article_title { get; set; }
        public Nullable<System.DateTime> mt_article_time { get; set; }
        public Nullable<int> mt_article_like { get; set; }
        public Nullable<int> mt_article_look { get; set; }
        public Nullable<int> mt_article_collect { get; set; }
        public string mt_article_cotent { get; set; }
        public string mt_user_id { get; set; }
    
        public virtual mt_articletype mt_articletype { get; set; }
    }
}