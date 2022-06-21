using System;
using Newtonsoft.Json;

namespace LatihanPolymorphism2;

public class ConvertToJson : ConvertObject
{
    public override void Convert(Mahasiswa mhs)
    {

        string json = JsonConvert.SerializeObject(mhs);
        Console.WriteLine("Hasil konversi ke JSON: \n");
        Console.WriteLine(json);
    }
}