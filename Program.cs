using KeinerMorales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    static void Main(String[] args)
    {
        int TOTAL = 5;
        int MENU;
        int MENU2;

        ValMone EST = new ValMone();
        List<ValMone> LISTAMon = new List<ValMone>(TOTAL);

        do
        {
            Console.WriteLine("\n 1. Ingresar Monedas \n 2. Cantidad de Monedas \n 3. Cantidad total de monedas \n 4. Cantidad de monedas por denominacion \n 5. Cantidad de monedas por denominacion \n 6. Exit");

            MENU = System.Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (MENU >= 1 || MENU <= 6)
            {
                Console.WriteLine("Error en sistema");
            }

            Console.Clear();

            switch (MENU)
            {

                case 1:

                    Console.WriteLine("Ingrese el valor de su moneda");
                    EST.MONEDA = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("\n 1. Ingresar moneda \n 2. Devolverse al menu anterior");
                    MENU2 = System.Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (MENU2 >= 1 || MENU2 <= 2)
                    {
                        Console.WriteLine("Error en sistema");
                    }
                    for (int index1 = 0; index1 < 100; index1++)
                    {
                        switch (MENU2)
                        {
                            case 2:

                                if (EST.MONEDA == 50 || EST.MONEDA == 100 || EST.MONEDA == 200 || EST.MONEDA == 500 || EST.MONEDA == 1000)
                                {
                                    Console.WriteLine("Ingrese el valor de su moneda");
                                    EST.MONEDA = int.Parse(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("Verifique que su moneda");
                                }
                                break;
                        }

                    }
                    break;
            }
        }
        while (MENU != 4);
        Console.Clear();
    }
}