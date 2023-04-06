using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UygulamaList.database;
using UygulamaList.entities;

namespace UygulamaList.businessService
{
    public class todoService
    {
        public int kayitKontrol()
        {
            return sanalDatabase.todoTablo.Count;
        }

        public List<todo> kayitListe()
        {
            return sanalDatabase.todoTablo;
        }

        public int kayitYeni(todo data)
        {
            try
            {
                sanalDatabase.todoTablo.Add(data);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
