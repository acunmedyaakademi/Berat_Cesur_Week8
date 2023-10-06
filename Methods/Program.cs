namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Length() : Bir dizideki karakter sayısını döndürür.
            string FullName = "Berat CESUR"; 
            Console.WriteLine("Karakter sayısı : " + FullName.Length);

            //Concat() : Verilen iki diziyi birleştirir.
            string name = "Berat ";
            string surName = "Cesur";
            string Name_SurName = string.Concat(name, surName);
            Console.WriteLine(Name_SurName);

            //ToUpper() : Dizideki tüm küçük harfleri büyük harfe çevirir.
            name.ToUpper();

            //ToLower() : Dizedeki tüm büyük harfleri küçük harfe dönüştürür.
            name.ToLower();

            //Substring() : Bir karakter aralığını çekip almamızı sağlar
            FullName.Substring(7);

            //IndexOf() : Bir dizgedeki belirli bir karakterin indeksini döndürür.
            Console.WriteLine(FullName.IndexOf(name));

            //LastIndexOf() : Bir alt dize veya karakterin son geçtiği dizinin dizinini döndürür.
            Console.WriteLine(FullName.LastIndexOf(name));

            //Contains() : Verilen alt dizginin dizgede var olup olmadığını kontrol eder.
            Console.WriteLine(FullName.Contains(name));
            Console.WriteLine(FullName.Contains(surName));

            //StartsWith methodu bir dizenin belirli bir alt dizeyle başlayıp başlamadığını kontrol eder.
            bool startsWith = FullName.StartsWith("Berat");

            //EndsWith metodu bir dizenin belirli bir alt dizeyle bittiğini kontrol eder.
            bool EndsWith = FullName.StartsWith("CESUR");

            //Replace() : Bir dizedeki bir alt dizeyi başka bir dizeyle değiştirir.
            string NewName = name.Replace("e", "a");
            Console.WriteLine(NewName);

            //Split() : Bir diziyi iki veya daha fazla parçaya böler.
            FullName.Split(' ');

            //Trim() : Dizedeki baştaki veya sondaki () içine girilen değeri kaldırır, () içi boş bırakılırsa boşluk olarak algılar.
            FullName.Trim();

            //TrimStart() : Dizedeki baştaki () içine girilen değeri kaldırır, () içi boş bırakılırsa boşluk olarak algılar.
            FullName = FullName.TrimStart();

            //TrimEnd() : Dizedeki  sondaki () içine girilen değeri kaldırır, () içi boş bırakılırsa boşluk olarak algılar.
            FullName = FullName.TrimEnd();

            //Format C#'da string bir ifade de belirtilen indekste değerleri görüntüler. Genellikle Tarihsel ve Rakamsal biçimlendirme için kullanılır.
            string.Format("Cebimde {0:C2} var.", 7);

            //Join() : Verilen ayırıcıyı kullanarak iki diziyi birleştirir.
            List<string> values = new List<string>();

            values.Add("1");
            values.Add("2");
            values.Add("3");

            string result = string.Join("-", values);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}