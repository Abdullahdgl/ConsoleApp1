// See https://aka.ms/new-console-template for more information
using Muzik;



MyMusic myMusic1 = new MyMusic();
myMusic1.MusicId = 3;
myMusic1.SanatciName = "Neşet Ertaş";
myMusic1.MusicName = "Deneme 0";

MyMusic myMusic2 = new MyMusic();
myMusic2.MusicId = 4;
myMusic2.SanatciName = "Abdullah Dağlı";
myMusic2.MusicName = "Deneme 1";
MyMusic myMusic3 = new MyMusic();
myMusic3.MusicId = 5;
myMusic3.SanatciName = "Abdullah Dağlı 2 ";
myMusic3.MusicName = "Deneme 2";
MyMusic myMusic4 = new MyMusic();
myMusic4.MusicId = 6;
myMusic4.SanatciName = "Abdullah Dağlı 3";
myMusic4.MusicName = "Deneme 3 ";

MusicManager musicManager = new MusicManager();
MyMusic[] myMusics = new MyMusic[] {myMusic1, myMusic2,myMusic3,myMusic4};

musicManager.GetList(myMusics);










