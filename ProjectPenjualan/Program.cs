using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan penjualan = new Penjualan();

            Console.WriteLine("Tambah Data Penjualan\n");
            Console.Write("Nota: ");
            penjualan.Nota = Console.ReadLine();
            Console.Write("Tanggal: ");
            penjualan.Tanggal = Console.ReadLine();
            Console.Write("Customer: ");
            penjualan.Customer = Console.ReadLine();
            Console.Write("Jenis [T/K]: ");
            string Jenis = Console.ReadLine();

            penjualan.Jenis = (Jenis == "t" || Jenis == "k") ? "Tunai" : "Kredit";

            Console.Write("Total Nota: ");
            penjualan.TN = Convert.ToInt32(Console.ReadLine());
            daftarPenjualan.Add(penjualan);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            bool status = false;
            Console.WriteLine("Hapus Data Penjualan\n");
            Console.Write("Nota: ");
            int TN = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < daftarPenjualan.Count; i++)
            {
                if (TN == daftarPenjualan[i].TN)
                {
                    daftarPenjualan.Remove(daftarPenjualan[i]);
                    status = true;
                    break;
                }
                else
                {
                    status = false;
                }
            }

            if (status)
            {
                Console.WriteLine("Data Penjualan berhasil di hapus");
            }
            else
            {
                Console.WriteLine("Nota tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            int nomor = 0;
            Console.WriteLine("Data Penjualan\n");
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                nomor++;
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", nomor, penjualan.Nota, penjualan.Tanggal, penjualan.Customer, penjualan.Jenis, penjualan.TN);
            }
            if (nomor < 1)
            {
                Console.WriteLine("\nData Produk Kosong \n");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
