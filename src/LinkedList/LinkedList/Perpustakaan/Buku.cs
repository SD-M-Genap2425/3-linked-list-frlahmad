using System;
using System.Collections.Generic;


namespace LinkedList.Perpustakaan
{
    public class Buku
    {
        public string Judul { get; }
        public string Penulis { get; }
        public int Tahun { get; }

        public Buku(string judul, string penulis, int tahun)
        {
            Judul = judul;
            Penulis = penulis;
            Tahun = tahun;
        }
    }
}