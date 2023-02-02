namespace convert_suhu{
    public enum Suhu
    {
        Farenhite = 'F',
        Celcius = 'C',
        Reamur = 'R',
        Kelvin = 'K'
    }

    public struct Suhu_Struct
    {
        public float value;
        public Suhu suhu;

        public Suhu_Struct(float _value,Suhu _suhu){
            value = _value;
            suhu = _suhu;
        }
    }

    static class Base_con{
        public static void print_suhu<T>(T value , Suhu suhu){
            System.Console.WriteLine("{0} {1}°",value,(char)suhu);
        }

        public static Suhu_Struct Suhu_convert(float value,Suhu IN_Suhu,Suhu OUT_Suhu){
            if (IN_Suhu.Equals(OUT_Suhu)){
                return new Suhu_Struct(value,OUT_Suhu);
            }

            switch (IN_Suhu)
            {
                case Suhu.Celcius:
                    switch (OUT_Suhu)
                    {
                        case Suhu.Farenhite:
                            return new Suhu_Struct(((9f/5f)*value)+32f,OUT_Suhu);
                        case Suhu.Kelvin:
                            return new Suhu_Struct(value + 273.15f,OUT_Suhu);
                        case Suhu.Reamur:
                            return new Suhu_Struct((4f/9f)*value,OUT_Suhu);
                    }
                    break;
                case Suhu.Farenhite:
                    switch (OUT_Suhu)
                    {
                        case Suhu.Celcius:
                            return new Suhu_Struct((5f/9f)*(value - 32f),OUT_Suhu) ;
                        case Suhu.Kelvin:
                            return new Suhu_Struct((value - 32f) * (5f/9f) + 273.15f,OUT_Suhu) ;
                        case Suhu.Reamur:
                            return new Suhu_Struct((4f/9f)*(value - 32f),OUT_Suhu) ;
                    }
                    break;
                case Suhu.Kelvin:
                    switch (OUT_Suhu)
                    {
                        case Suhu.Celcius:
                            return new Suhu_Struct(value - 273.15f,OUT_Suhu) ;
                        case Suhu.Farenhite:
                            return new Suhu_Struct((9f/5f)*(value - 273.15f) + 32f,OUT_Suhu) ;
                        case Suhu.Reamur:
                            return new Suhu_Struct((4f/5f)*(value - 273.15f),OUT_Suhu) ;
                    }
                    break;
                case Suhu.Reamur:
                    switch (OUT_Suhu)
                    {
                        case Suhu.Celcius:
                            return new Suhu_Struct((5f/4f)*value,OUT_Suhu) ;
                        case Suhu.Farenhite:
                            return new Suhu_Struct(((9f/4f)*value) + 32f,OUT_Suhu) ;
                        case Suhu.Kelvin:
                            return new Suhu_Struct((-(5f/4f))*value + 273.15f,OUT_Suhu) ;
                    }
                    break;
            
            }

            return new Suhu_Struct();
        }
    }
}