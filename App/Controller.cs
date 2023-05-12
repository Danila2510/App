using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App;

namespace App
{
    class Controller
    {
        public string GetBook(string bookname)
        {
            Database db = new Database();
            
            string rez = db.Search(bookname);
            if(rez!=null)
            {
                return rez.ToString();
            }
            return "Книга не найдена!";
        }
    }
}
