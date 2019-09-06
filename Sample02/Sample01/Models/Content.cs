﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample01.Models
{
    public class Content
    {
        //主键
        public int Id { get; set; }
        //标题
        public string title { get; set;}
        //内容
        public string content { get; set; }
        //状态 1 正常 0 删除
        public int status { get; set; }
        //创建时间
        public DateTime add_time { get; set; }
        //修改时间
        public DateTime modify_time { get; set; }
    }
}
