using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Perpustakaan
{
    public class KoleksiPerpustakaan
    {
        private BukuNode head;

        public void TambahBuku(Buku buku)
        {
            BukuNode newNode = new BukuNode(buku);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                BukuNode temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }

        public bool HapusBuku(string judul)
        {
            if (head == null) return false;

            if (head.Data.Judul == judul)
            {
                head = head.Next;
                return true;
            }

            BukuNode temp = head;
            while (temp.Next != null && temp.Next.Data.Judul != judul)
            {
                temp = temp.Next;
            }

            if (temp.Next == null) return false;

            temp.Next = temp.Next.Next;
            return true;
        }

        public Buku[] CariBuku(string kataKunci)
        {
            List<Buku> hasilPencarian = new List<Buku>();
            BukuNode temp = head;
            while (temp != null)
            {
                if (temp.Data.Judul.Contains(kataKunci, StringComparison.OrdinalIgnoreCase))
                {
                    hasilPencarian.Add(temp.Data);
                }
                temp = temp.Next;
            }
            return hasilPencarian.ToArray();
        }

        public string TampilkanKoleksi()
        {
            List<string> daftarBuku = new List<string>();
            BukuNode temp = head;
            while (temp != null)
            {
                daftarBuku.Add($"\"{temp.Data.Judul}\"; {temp.Data.Penulis}; {temp.Data.Tahun}");
                temp = temp.Next;
            }
            return string.Join("\n", daftarBuku);
        }
    }
}