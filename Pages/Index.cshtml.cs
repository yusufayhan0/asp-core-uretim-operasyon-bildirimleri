using System;
using System.Collections; 

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using UretimOperasyonBildirimleri.Models;


namespace UretimOperasyonBildirimleri.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Context _logger;

        public IndexModel(Context logger)
        {
            _logger = logger;
        }
        public IList<bildirim> bildirims { get; set; }
        public IList<duruslar> duruslars { get; set; }
        public int kontrol(DateTime t1,DateTime t2){
            return DateTime.Compare(t1,t2);
        }
        public string fark(DateTime t1,DateTime t2){
            return (t1-t2).ToString();
        }

        public bool nedenVarmi(string deger){
            if (deger!=string.Empty)
            {
                return true;
            }
            return false;
        }
        public async Task OnGetAsync()
        {
            
            bildirims = await _logger.bildirims.AsNoTracking().ToListAsync();
            duruslars = await _logger.duruslars.AsNoTracking().ToListAsync();
        }
    }
}
