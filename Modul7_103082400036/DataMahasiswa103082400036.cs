using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_103082400036
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public class DataMahasiswa103082400036
    {
        public void ReadJSON()
        {
          
            string jsonString = File.ReadAllText("jurnal7_1_103082400036.json");
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine($"Nama: {mhs.nama.depan} {mhs.nama.belakang}");
            Console.WriteLine($"NIM: {mhs.nim}");
            Console.WriteLine($"Fakultas: {mhs.fakultas}");
        }
    }
}