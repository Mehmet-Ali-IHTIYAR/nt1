using System; 
using System.Collections;
namespace sevincomer{


	interface IRenklendir{

		 void Renklendir();

	}
	
	public class Sekil { 
		public const double PI = Math.PI; 
		protected double x, y; 
		
		public Sekil() { } 

		public Sekil(double x, double y) 
		{ 
			this.x= x; 
			this.y= y; 
			} 
		
		public virtual double Alan() { return x * y; }

	}

    class Daire : Sekil , IComparable , IRenklendir
    { 
    	public Daire(double r) : base(r, 0) {} 
    	public String renk; 
    	public override double Alan() { return PI * x * x; }
    		
    		public int CompareTo(object o) {
    		
    			 if (o == null) return 1;

        		Daire digerDaire = o as Daire;

        		if (digerDaire != null) 
            return this.x.CompareTo(digerDaire.x);
        else
           throw new ArgumentException("Bir daire nesnesi değil!");  // Hata Fırlat
    		}

    		public void Renklendir()
    		{
    			if(this.x < 10 ) this.renk = "Siyah";
    			else if(this.x <= 20 ) this.renk = "Kırmızı";
    			else if(this.x <= 30 ) this.renk = "Mavi";
    			else renk = "Beyaz"; 
    			Console.WriteLine("Dairenin rengi : " + this.renk);
    		}
    
    }

    class Kure: Sekil { 
    	public Kure(double r) : base(r, 0) { } 
    	public override double Alan() { return 4 * PI * x * x; } 
   
    }

 	class Silindir : Sekil 
	{
	
	public Silindir(double r, double h) : base(r, h) { }
	
	public override double Alan()
		{ return 2 * PI * x * x + 2 * PI * x * y; }

		

		
	}

	public class VirtualOverrideTest{

		static void Main(String[] args)
		{

			Daire d1 = new Daire(20);
			Daire d2 = new Daire(20);
			Kure k1 = new Kure(10);
			Silindir s1 = new Silindir(10,5); 
			Console.WriteLine("Dairenin alanı : {0}", d1.Alan());
			Console.WriteLine("Kürenin alanı : {0}", k1.Alan());
			Console.WriteLine("Silindirin alanı : {0}", s1.Alan());

			Console.WriteLine("d1 ve d2 daireleri kıyaslanırsa : {0} ", d1.CompareTo(d2));
			d1.Renklendir(); 

		}

	}


}