using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muzik
{
    public class MusicManager
    {
        public void Ekle(MyMusic myMusic)
        {
            Console.WriteLine(myMusic.MusicId +" " +myMusic.MusicName + " " + myMusic.SanatciName +  " Eklendi.");

        }
        public void Sil(MyMusic myMusic)
        {
            Console.WriteLine("Silindi.");
        }

       public void GetList(MyMusic[] myMusics) {

            Console.WriteLine(" Muzikler listelendi.");
            foreach (MyMusic myMusic in myMusics)
            {
                Console.WriteLine(" Müzikler Listelendi . " + myMusic.MusicName);

            }



        }
    }
}
