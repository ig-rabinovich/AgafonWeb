using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgafonWeb.Pages
{
    public class ExperimentModel : PageModel
    {
        [BindProperty]
        public int sum1 { get; set; }
        [BindProperty]
        public int sum2 { get; set; }
        public string MessageResult { get; set; }
        
        public void OnGet()
        {
            MessageResult = "�����";
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                MessageResult = "������� �������� �����";
            }
            else
            {
                int result = sum1 + sum2;
                MessageResult = $"����� {sum1} � {sum2} ��������� {result.ToString("F2")}";// ToString("F2") - �������������� �����: F2 - ������� ����� � 2 ������� ����� �������
            }
        }
    }
}
