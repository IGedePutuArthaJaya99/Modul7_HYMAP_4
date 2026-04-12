using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul7_103082400036
{
    public class GlossaryItem103082400036
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_3_103082400036.json");

            // Menggunakan JsonDocument untuk menelusuri hierarki JSON
            using (JsonDocument doc = JsonDocument.Parse(jsonString))
            {
                JsonElement root = doc.RootElement;

                // Mengambil nilai mulai dari glossary -> GlossDiv -> GlossList -> GlossEntry
                JsonElement glossEntry = root.GetProperty("glossary")
                                             .GetProperty("GlossDiv")
                                             .GetProperty("GlossList")
                                             .GetProperty("GlossEntry");

                Console.WriteLine("Isi dari GlossEntry:");

                // Menampilkan isi khusus GlossEntry secara manual
                Console.WriteLine($"ID: {glossEntry.GetProperty("ID").GetString()}");
                Console.WriteLine($"Term: {glossEntry.GetProperty("GlossTerm").GetString()}");
                Console.WriteLine($"Acronym: {glossEntry.GetProperty("Acronym").GetString()}");
                Console.WriteLine($"Abbrev: {glossEntry.GetProperty("Abbrev").GetString()}");

                // Mengambil bagian GlossDef
                JsonElement glossDef = glossEntry.GetProperty("GlossDef");
                Console.WriteLine($"Definition: {glossDef.GetProperty("para").GetString()}");
            }
        }
    }
}
