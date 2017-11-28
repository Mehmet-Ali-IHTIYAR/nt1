using System; 


namespace Kalitim{

	class Kalem{


		public Kalem(string r, int u){

			Renk = r; 
			Uzunluk = u; 
		}

		public virtual void Yaz(string bilgi ){Console.WriteLine("Kalem Yazdı : " + bilgi); }
		
		public int Uzunluk  {get;set;}

		private string _renk;
		public string Renk  // _renk değişkeni için özellik tanımı 
		{
			get{ return _renk; }
			set {_renk = value; }
		}

		public virtual void KalemBilgisiYaz(){
			Console.WriteLine("Kelemin özellikleri renk : " + Renk + " uzunluk : " + Uzunluk); 
		}


	} 

	class Tukenmez:Kalem{

		private int omur; 
		public Tukenmez(string r, int u):base(r,u)
		{
			omur = 30;
		}

		public override void  KalemBilgisiYaz()
		 { 
		 	base.KalemBilgisiYaz(); 
		 	Console.WriteLine("Tükenmez kalemin ömrü : " + omur);
		 }

		 


		 public override void Yaz(String b){base.Yaz(b); }

	}

	class Kursun:Kalem{

		private string yumusaklik; 

		public Kursun(string r, int u):base(r,u)  // Kursun sınıdının Kurucu Metot
		{
			yumusaklik = "HB";
		}


		public Kursun(string r, int u, string y):base(r,u)  // Kursun sınıdının Kurucu Metot
		{
			yumusaklik = y;
		}

		public override void  KalemBilgisiYaz()
		{
			base.KalemBilgisiYaz(); 
			Console.WriteLine("Kurşun kalemin yumuşakık değeri : " + yumusaklik);
		}

		public override void Yaz(string y){ base.Yaz(y); }


	}

	class Program{

		public static void Main(String[] args)
		{
			Tukenmez t1  = new Tukenmez("Kirmizi", 15); 
			Kursun k1 = new Kursun("Siyah",10);
			Kursun k2 = new Kursun("Mavi",12,"2BB");
			t1.KalemBilgisiYaz();
			k1.KalemBilgisiYaz();
			k2.KalemBilgisiYaz();
			Console.ReadKey();

		}

	}

}
