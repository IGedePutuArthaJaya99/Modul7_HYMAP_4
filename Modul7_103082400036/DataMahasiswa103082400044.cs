using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_103082400044
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    
        public class Alamat
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class MataKuliah
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public class Mahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public Alamat address { get; set; }
            public List<MataKuliah> courses { get; set; }
        }

        public class DataMahasiswa103082400044
        {
            public void ReadJSON()
            {
                string jsonString = File.ReadAllText("jurnal7_1_103082400044.json");
                Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

                Console.WriteLine($"Nama: {mhs.firstName} {mhs.lastName}");
                Console.WriteLine($"Gender: {mhs.gender}");
                Console.WriteLine($"Umur: {mhs.age}");
                Console.WriteLine($"Alamat: {mhs.address.streetAddress}, {mhs.address.city}, {mhs.address.state}");
                Console.WriteLine("Mata Kuliah:");
                foreach (var mk in mhs.courses)
                {
                    Console.WriteLine($"- {mk.code}: {mk.name}");
                }
            }
        }
    }
