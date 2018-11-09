using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParseWebDataApp.Models
{
    /// <summary>
    /// 解析商品資訊
    /// </summary>
    public class WebPageData
    {
        public string item_name { get; set; }//商品名稱
        public int price { get; set; }//商品價格
        public string pic { get; set; }//商品圖片
    }
}