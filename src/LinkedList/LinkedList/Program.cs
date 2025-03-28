using LinkedList.Perpustakaan;
using LinkedList.ManajemenKaryawan;
using LinkedList.Inventori;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soal Perpustakaan
            KoleksiPerpustakaan koleksi = new KoleksiPerpustakaan();

            Buku buku1 = new Buku("The Hobbit", "J.R.R. Tolkien", 1937);
            Buku buku2 = new Buku("1984", "George Orwell", 1949);
            Buku buku3 = new Buku("The Catcher in the Rye", "J.D. Salinger", 1951);

            koleksi.TambahBuku(buku1);
            koleksi.TambahBuku(buku2);
            koleksi.TambahBuku(buku3);

            Console.WriteLine("Koleksi Buku:");
            Console.WriteLine(koleksi.TampilkanKoleksi());

            Console.WriteLine("\nHasil Pencarian Buku dengan kata kunci 'Hobbit':");
            Buku[] cariBuku = koleksi.CariBuku("Hobbit");
            foreach (Buku buku in cariBuku)
            {
                if (buku != null)
                {
                    Console.WriteLine($"{buku.Judul} - {buku.Penulis} ({buku.Tahun})");
                }
            }

            bool hapusBuku = koleksi.HapusBuku("1984");
            Console.WriteLine($"\nBuku '1984' dihapus: {hapusBuku}");

            Console.WriteLine("\nKoleksi Buku Setelah Penghapusan:");
            Console.WriteLine(koleksi.TampilkanKoleksi());

            // Soal ManajemenKaryawan
            DaftarKaryawan daftar = new DaftarKaryawan();

            Karyawan karyawan1 = new Karyawan("001", "John Doe", "Manager");
            Karyawan karyawan2 = new Karyawan("002", "Jane Doe", "HR");
            Karyawan karyawan3 = new Karyawan("003", "Bob Smith", "IT");

            daftar.TambahKaryawan(karyawan1);
            daftar.TambahKaryawan(karyawan2);
            daftar.TambahKaryawan(karyawan3);

            Console.WriteLine("Daftar Karyawan:");
            Console.WriteLine(daftar.TampilkanDaftar());

            Console.WriteLine("\nHasil Pencarian Karyawan dengan kata kunci 'Doe':");
            Karyawan[] cariKaryawan = daftar.CariKaryawan("Doe");
            foreach (Karyawan karyawan in cariKaryawan)
            {
                if (karyawan != null)
                {
                    Console.WriteLine($"{karyawan.NomorKaryawan} - {karyawan.Nama} ({karyawan.Posisi})");
                }
            }

            bool hapusKaryawan = daftar.HapusKaryawan("002");
            Console.WriteLine($"\nKaryawan dengan nomor '002' dihapus: {hapusKaryawan}");

            Console.WriteLine("\nDaftar Karyawan Setelah Penghapusan:");
            Console.WriteLine(daftar.TampilkanDaftar());

            // Soal Inventori
            ManajemenInventori inventori = new ManajemenInventori();

            Item item1 = new Item("Apple", 50);
            Item item2 = new Item("Orange", 30);
            Item item3 = new Item("Banana", 20);

            inventori.TambahItem(item1);
            inventori.TambahItem(item2);
            inventori.TambahItem(item3);

            Console.WriteLine("Daftar Inventori:");
            Console.WriteLine(inventori.TampilkanInventori());

            bool dihapus = inventori.HapusItem("Orange");
            Console.WriteLine($"\nItem 'Orange' dihapus: {dihapus}");

            Console.WriteLine("\nDaftar Inventori Setelah Penghapusan:");
            Console.WriteLine(inventori.TampilkanInventori());
        }
    }
}