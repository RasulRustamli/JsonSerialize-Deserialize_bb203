using Json_Serialize_Deserialize_Shahbaz.Models;
using Newtonsoft.Json;

namespace Json_Serialize_Deserialize_Shahbaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catagory komputer = new Catagory()
            {
                Name = "Komputer"
            };
            Product Acer = new Product()
            {
                Name = "Acer"
            };
            Product MSI = new Product()
            {
                Name = "MSI"
            };
            Product Asus = new Product()
            {
                Name = "Asus"
            };
            komputer.Products = new List<Product>()
            {
                Acer, MSI, Asus
            };
            string json = JsonConvert.SerializeObject(komputer.Products);
            using (StreamWriter sw = new StreamWriter(@"C:\Users\rasul\OneDrive\Masaüstü\Json Serialize,Deserialize-Shahbaz\Json Serialize,Deserialize-Shahbaz\JSon\catagory.json")) 
            {

                sw.Write(json);
            }


            using (StreamReader sReader = new StreamReader(@"C:\Users\rasul\OneDrive\Masaüstü\Json Serialize,Deserialize-Shahbaz\Json Serialize,Deserialize-Shahbaz\JSon\catagory.json"))
            {
                string jsonText = sReader.ReadToEnd();
                List<Product> Products = JsonConvert.DeserializeObject<List<Product>>(jsonText);

                foreach (var item in Products)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}