using System;
namespace LatihanPolymorphism2;

public class Program
{
    static void Main()
    {
        Mahasiswa mhs = new Mahasiswa();
        mhs.npm = "21.11.1111";
        mhs.nama = "Muhammad Irvan Shandika";
        mhs.email = "irvanshandika@amikom.ac.id";
        Console.WriteLine("Pilih format konversi data : ");
        Console.WriteLine("1. JSON");
        Console.WriteLine("2. XML");
        Console.WriteLine("3. CSV");
            
        Console.Write("Nomor format data [1...3] : ");
        int nomorFormatData = Convert.ToInt32(Console.ReadLine());

        ConvertObject convert;

        if (nomorFormatData == 1)
            convert = new ConvertToJson();
        else if (nomorFormatData == 2)
            convert = new ConvertToXml();
        else
            convert = new ConvertToCsv();
            
        convert.Convert(mhs);
        Console.ReadKey();
    }
}