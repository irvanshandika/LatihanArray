using System;

namespace Array
{
    class program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.Nama = "Erik";
            mhs1.Nilai = 75;

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.Nama = "Wely";
            mhs2.Nilai = 80;
            
            Mahasiswa mhs3 = new Mahasiswa();
            mhs3.Nim = "1235";
            mhs3.Nama = "Sony";
            mhs3.Nilai = 95;

            Mahasiswa[] arrMahasiswa = new Mahasiswa[3];

            arrMahasiswa[0] = mhs1;
            arrMahasiswa[1] = mhs2;
            arrMahasiswa[2] = mhs3;
            
            Console.WriteLine("No Nama NIM Nilai");

            for (int i = 0; i < arrMahasiswa.Length; i++)
            {
                Mahasiswa mhs = arrMahasiswa[i];
                Console.WriteLine("{0}. {1} {2} {3}", i+1, mhs.Nama, mhs.Nim, mhs.Nilai);
            }
            Console.ReadKey();
        }
    }
}