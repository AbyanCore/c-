using System.Numerics;
using System.Linq;
using convert_suhu;

namespace Core{
    class Program{
        static void Main(string[] args)
        {
            Suhu_Struct x = Base_con.Suhu_convert(10,Suhu.Celcius,Suhu.Kelvin);
        
            Base_con.print_suhu<float>(x.value,x.suhu);
            List<object> v = new List<object>(Enum.GetValues(typeof(Suhu)));
            foreach (var item in v)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
