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
            MessageResult = "Сумма";
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                MessageResult = "Введены неверные числа";
            }
            else
            {
                int result = sum1 + sum2;
                MessageResult = $"Сумма {sum1} и {sum2} равняется {result.ToString("F2")}";// ToString("F2") - форматирование числа: F2 - дробное число с 2 знаками после запятой
            }
        }
    }
}
