using System; 

namespace sevinc.omer {


	class ikinciOrnek{

		static void Main(String[] args)
		{

			int a,b,toplam; 

			Console.Write("İlk değeri giriniz : ");
			a = Convert.toInt16(Console.ReadLine());

			Console.Write("İkinci değeri giriniz : ");
			b = Convert.toInt16(Console.ReadLine());

			toplam = a + b ; 
			Console.WriteLine(); 

			Console.WriteLine("{0} ve {1} sayılarının toplamı : {2}", a,b,(a + b));
			
			Console.ReadKey();

		}


	}

}