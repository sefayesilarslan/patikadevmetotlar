namespace Metotlar
{

    class metot{

        public static void Main(string[] args){

       //erişim_belirleyici geri_donus_tipi metot_adi(Parametre_listesi/arguman){//komutlar}

        int a=80;
        int b=20;

        int sonuc=Topla(a,b);

        metotlar örnek=new metotlar();

        örnek.ekranaYaz(Convert.ToString(sonuc));


        int sonuc2 = örnek.arttirveTopla(ref a, ref b);
        
        örnek.ekranaYaz(Convert.ToString(sonuc2));


        }

        static int Topla(int deger1, int deger2){

        return(deger1+deger2);
        
        }
    }

    class metotlar{

        public void ekranaYaz(string veri){

            Console.WriteLine(veri);
        }

        public int arttirveTopla(ref int deger1,ref int deger2){ // ref anahtar kelimesini kullanırsak global değişkeni işaret eder ve değişiklik olunca globaldeki değer değişir 
            deger1+=1;
            deger2+=2;
            return deger1 + deger2;
        }
    }
    
}
