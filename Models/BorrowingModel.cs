using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Models
{
    public class BorrowingModel
    {
        public int id_borrowing { get; set; }
        public int id_book { get; set; }
        public int id_reader { get; set; }

        public string borrowing_date { get; set; }

        public string expiration_date { get; set; }

    }
}
