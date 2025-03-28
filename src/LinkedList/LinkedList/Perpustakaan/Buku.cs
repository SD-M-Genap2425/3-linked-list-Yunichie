namespace LinkedList.Perpustakaan
{
    public class Buku
    {
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public int Tahun { get; set; }

        public Buku(string judul, string penulis, int tahun)
        {
            Judul = judul;
            Penulis = penulis;
            Tahun = tahun;
        }
    }
}
