using System;
namespace LatihanPolymorphism2;

public class ConvertToCsv : ConvertObject
{
    public override void Convert(Mahasiswa mhs)
    {

        string csv = string.Format("{0}, {1}, {2}", mhs.npm, mhs.nama, mhs.email);
        
        Console.WriteLine("Hasil konversi ke CSV : \n");
        Console.WriteLine(csv);
    }
}