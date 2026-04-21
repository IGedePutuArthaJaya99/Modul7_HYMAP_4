using Modul7_103082400020;
using System;


namespace Modul7_103082400020
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa103082400020 dataMhs = new DataMahasiswa103082400020();
            dataMhs.ReadJSON();

            Console.WriteLine();

            TeamMembers103082400020 team = new TeamMembers103082400020();
            team.ReadJSON();

            Console.WriteLine();

            GlossaryItem103082400020 gloss = new GlossaryItem103082400020();
            gloss.ReadJSON();
        }
    }
}