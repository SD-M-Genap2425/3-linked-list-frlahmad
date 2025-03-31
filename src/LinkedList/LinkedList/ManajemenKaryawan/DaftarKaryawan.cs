using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.ManajemenKaryawan
{
    public class DaftarKaryawan
    {
        private KaryawanNode head;
        private KaryawanNode tail;

        public void TambahKaryawan(Karyawan karyawan)
        {
            KaryawanNode newNode = new KaryawanNode(karyawan);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }

        public bool HapusKaryawan(string nomorKaryawan)
        {
            KaryawanNode temp = head;
            while (temp != null)
            {
                if (temp.Karyawan.NomorKaryawan == nomorKaryawan)
                {
                    if (temp.Prev != null)
                        temp.Prev.Next = temp.Next;
                    else
                        head = temp.Next;

                    if (temp.Next != null)
                        temp.Next.Prev = temp.Prev;
                    else
                        tail = temp.Prev;

                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        public Karyawan[] CariKaryawan(string kataKunci)
        {
            List<Karyawan> hasilPencarian = new List<Karyawan>();
            KaryawanNode temp = head;
            while (temp != null)
            {
                if (temp.Karyawan.Nama.Contains(kataKunci, StringComparison.OrdinalIgnoreCase) ||
                    temp.Karyawan.Posisi.Contains(kataKunci, StringComparison.OrdinalIgnoreCase))
                {
                    hasilPencarian.Add(temp.Karyawan);
                }
                temp = temp.Next;
            }
            return hasilPencarian.ToArray();
        }

        public string TampilkanDaftar()
        {
            List<string> daftarKaryawan = new List<string>();
            KaryawanNode temp = tail;
            while (temp != null)
            {
                daftarKaryawan.Add($"{temp.Karyawan.NomorKaryawan}; {temp.Karyawan.Nama}; {temp.Karyawan.Posisi}");
                temp = temp.Prev;
            }
            return string.Join("\n", daftarKaryawan);
        }
    }
}