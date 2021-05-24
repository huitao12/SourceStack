using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SourceStack.Pages.Profile
{
    public class IndexModel : PageModel
    {
        public User NewUser { get; set; }
        //年份
        public string BirthYear { get; set; }
        public IEnumerable<SelectListItem> AvailableYears { get; set; }
        //月份
        public string  BirthMonth { get; set; }
        public IEnumerable<SelectListItem> AvailableMonths { get; set; }
        //星座
        public string Constellation { get; set; }
        public IEnumerable<SelectListItem> AvailableConstellations { get; set; }
        //一级
        public string StairKeyword { get; set; }
        public IEnumerable<SelectListItem> AvailableStairKeywords { get; set; }
        //二级
        public string SecondKeyword { get; set; }
        public IEnumerable<SelectListItem> AvailableSecondKeywords { get; set; }

        public void OnGet()
        {
            AvailableYears = new SelectList(new int[] { 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000 });
            AvailableMonths = new SelectList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            AvailableConstellations = new SelectList(new string[] { "宝瓶座", "双鱼座", "牡羊座", "金牛座", "双子座", "巨蟹座", "狮子座", "处女座", "天平座", "天蝎座", "人马座", "山羊座", });
            AvailableStairKeywords = new SelectList(new string[] { "编程开发", "工具软件", "顾问咨询", "操作系统", });
            AvailableSecondKeywords = new SelectList(new string[] { "C#", "JAVA", "HTML", "SQL", "JavaScript", "C++", "PHP" });
        }
        public void OnPost()
        {

        }
    }
}
