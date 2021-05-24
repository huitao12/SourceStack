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
        //���
        public string BirthYear { get; set; }
        public IEnumerable<SelectListItem> AvailableYears { get; set; }
        //�·�
        public string  BirthMonth { get; set; }
        public IEnumerable<SelectListItem> AvailableMonths { get; set; }
        //����
        public string Constellation { get; set; }
        public IEnumerable<SelectListItem> AvailableConstellations { get; set; }
        //һ��
        public string StairKeyword { get; set; }
        public IEnumerable<SelectListItem> AvailableStairKeywords { get; set; }
        //����
        public string SecondKeyword { get; set; }
        public IEnumerable<SelectListItem> AvailableSecondKeywords { get; set; }

        public void OnGet()
        {
            AvailableYears = new SelectList(new int[] { 1990, 1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000 });
            AvailableMonths = new SelectList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            AvailableConstellations = new SelectList(new string[] { "��ƿ��", "˫����", "ĵ����", "��ţ��", "˫����", "��з��", "ʨ����", "��Ů��", "��ƽ��", "��Ы��", "������", "ɽ����", });
            AvailableStairKeywords = new SelectList(new string[] { "��̿���", "�������", "������ѯ", "����ϵͳ", });
            AvailableSecondKeywords = new SelectList(new string[] { "C#", "JAVA", "HTML", "SQL", "JavaScript", "C++", "PHP" });
        }
        public void OnPost()
        {

        }
    }
}
