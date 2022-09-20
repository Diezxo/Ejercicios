namespace Lluvia
{

    class agua
    {
        public int gotas_dia { get; set; }
        public int gotas_promedio { get; set; }
        public int gotas_menor { get; set; }
        public int gotas_mayor { get; set; }
        public int dias_evaluados { get; set; }
        

        public static void Main(string[] args)
            { Console.WriteLine("Cuantos dias deseas evaluar");
                var dias_evaluados = Convert.ToInt16(Console.ReadLine());
                 agua llovizna = new agua(); 

                for (int i = 1; i <= dias_evaluados; i++)
                { Console.WriteLine("Dia: " + i);
                Console.WriteLine("-----------");
                    Console.WriteLine("Escribe Cuantas gotas de agua registraste en el dia");
                    var gotas_dia = Convert.ToInt32(Console.ReadLine());

                    if (i == 1 || gotas_dia > llovizna.gotas_mayor)
                        llovizna.gotas_mayor = gotas_dia;
                    if (i == 1 || gotas_dia < llovizna.gotas_menor)
                        llovizna.gotas_menor = gotas_dia;

                        llovizna.gotas_promedio += gotas_dia;
         
                 }
                if (dias_evaluados != 0)
                {
                    llovizna.gotas_promedio /= dias_evaluados;
                }
         Console.WriteLine("El Mayor Numero de Gotas registradas en un dia fue de: "+llovizna.gotas_mayor);
         Console.WriteLine("La menor cantidad de gotas registradas fue de: "+llovizna.gotas_menor);
         Console.WriteLine("El Promedio entre todos los dias evaluados es "+llovizna.gotas_promedio+" gotas de agua");
        }

        
    }
}