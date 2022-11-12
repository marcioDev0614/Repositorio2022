﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class SwitchCase
    {
        static void Main_()
        {
            Console.Write("Informe o valor para o dia da semana entre 1 e 7: ");
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "Domingo";
                    break;
                case 2:
                    day = "Segunda";
                    break;
                case 3:
                    day = "Terça";
                    break;
                case 4:
                    day = "Quarta";
                    break;
                case 5:
                    day = "Quinta";
                    break;
                case 6:
                    day = "Sexta";
                    break;
                case 7:
                    day = "Sábado";
                    break;
                default:
                    day = "Inválido";
                    break;
            }

            Console.WriteLine("Dia: " + day);
        }
    }
}
