using System;

class Program
{
    static void Main()
    {
        // Input nama user
        Console.Write("Masukkan nama user: ");
        string nama = Console.ReadLine();

        // Input jumlah tiket yang ingin dibeli
        Console.Write("Masukkan jumlah tiket (1-5): ");
        int jumlahTiket = int.Parse(Console.ReadLine());

        // Input jumlah transaksi sebelumnya
        Console.Write("Berapa kali sudah transaksi sebelumnya: ");
        int jumlahTransaksi = int.Parse(Console.ReadLine());

        // Harga tiket per 1
        int hargaTiket = 100000;

        // Validasi jumlah tiket (harus 1 sampai 5)
        if (jumlahTiket < 1 || jumlahTiket > 5)
        {
            Console.WriteLine("Jumlah tiket tidak valid!");
        }
        else
        {
            // Hitung total awal
            int total = jumlahTiket * hargaTiket;

            // Jika transaksi sudah lebih dari 5x → hentikan proses
            if (jumlahTransaksi > 5)
            {
                Console.WriteLine("Transaksi dihentikan!");
                Console.WriteLine("Jumlah tiket: " + jumlahTiket);
                Console.WriteLine("Total bayar: " + total);
            }
            else
            {
                // Variabel untuk menyimpan total diskon
                double diskon = 0;

                // Jika beli 5 tiket → diskon 10%
                if (jumlahTiket == 5)
                {
                    diskon += 0.10;
                }

                // Jika transaksi lebih dari 3x → tambahan diskon 5%
                if (jumlahTransaksi > 3)
                {
                    diskon += 0.05;
                }

                // Hitung total setelah diskon
                double totalBayar = total - (total * diskon);

                // Output hasil akhir
                Console.WriteLine("Nama: " + nama);
                Console.WriteLine("Jumlah tiket: " + jumlahTiket);
                Console.WriteLine("Total sebelum diskon: " + total);
                Console.WriteLine("Diskon: " + (diskon * 100) + "%");
                Console.WriteLine("Total bayar: " + totalBayar);
            }
        }
    }
}