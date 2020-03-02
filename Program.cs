using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Naprendszer
{
  struct Bolygo
  {
    public string nev;
    public int fk;
    public int ft;
  }

  class Program
  {
    static void Main(string[] args)
    {
      // Adatok eltárolása
      

      StreamReader file = new StreamReader("bolygok.txt");

      #region Amikor tudjuk, hogy mennyi adat van!
      //Bolygo[] bolygok = new Bolygo[7];
      //for (int i = 0; i < 7; i++)
      //{
      //  // egy sor beolvasás a fájlból
      //  string sor = file.ReadLine();

      //  // a "sor" felbontása szóközök mentén
      //  string[] a = sor.Split(' ');

      //  // adatok átadása
      //  bolygok[i].nev = a[0];
      //  bolygok[i].fk = Convert.ToInt32(a[1]);
      //  bolygok[i].ft = Convert.ToInt32(a[2]);
      //} 
      #endregion

      #region Amikor nem tudjuk, hogy mennyi adat van!
      // max 200 lehet!
      Bolygo[] bolygok = new Bolygo[200];
      int db = 0; // tényleges darabszám

      while (!file.EndOfStream)
      {
        // egy sor beolvasás a fájlból
        string sor = file.ReadLine();

        // a "sor" felbontása szóközök mentén
        string[] a = sor.Split(' ');

        // adatok átadása
        bolygok[db].nev = a[0];
        bolygok[db].fk = Convert.ToInt32(a[1]);
        bolygok[db].ft = Convert.ToInt32(a[2]);
        db++;
      }

      #endregion

      file.Close();
      
      // Adatok képernyőre írása
      Console.WriteLine("Bolygók adatai");
      Console.WriteLine("Név        Földközeli Földtávoli");
      Console.WriteLine("--------------------------------");
      // for(int i = 0; i < 7; i++)
      for (int i = 0; i < db; i++)
      {
        Console.WriteLine("{0,-10} {1,10} {2,10}",
          //bolygok[i].nev.PadRight(10),
          //bolygok[i].fk.ToString().PadLeft(10),
          //bolygok[i].ft.ToString().PadLeft(10)
          bolygok[i].nev,
          bolygok[i].fk,
          bolygok[i].ft
        );
      }
      Console.WriteLine("--------------------------------");



      Console.ReadLine();
    }
  }
}
