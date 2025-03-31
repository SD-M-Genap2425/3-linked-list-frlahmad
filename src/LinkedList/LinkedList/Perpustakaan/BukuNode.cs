using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Perpustakaan
{
    public class BukuNode
    {
        public Buku Data { get; }
        public BukuNode Next { get; set; }

        public BukuNode(Buku buku)
        {
            Data = buku;
            Next = null;
        }
    }
}