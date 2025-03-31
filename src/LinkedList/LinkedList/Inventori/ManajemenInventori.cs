using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Inventori
{
    public class ManajemenInventori
    {
        private LinkedList<Item> inventori;

        public ManajemenInventori()
        {
            inventori = new LinkedList<Item>();
        }

        public void TambahItem(Item itemBaru)
        {
            var item = inventori.FirstOrDefault(i => i.Nama.Equals(itemBaru.Nama, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                item.Kuantitas += itemBaru.Kuantitas;
            }
            else
            {
                inventori.AddLast(itemBaru);

            }
        }


        public bool HapusItem(string nama)
        {
            var itemDihapus = inventori.FirstOrDefault(item => item.Nama.Equals(nama, StringComparison.OrdinalIgnoreCase));
            if (itemDihapus != null)
            {
                inventori.Remove(itemDihapus);
                return true;
            }
            return false;
        }


        public void CetakInventori()
        {
            Console.WriteLine("Inventori saat ini:");
            foreach (var item in inventori)
            {
                Console.WriteLine($"{item.Nama}: {item.Kuantitas}");
            }
        }


        public string TampilkanInventori()
        {
            return string.Join(Environment.NewLine, inventori.Select(i => $"{i.Nama}; {i.Kuantitas}"));
        }



    }

}