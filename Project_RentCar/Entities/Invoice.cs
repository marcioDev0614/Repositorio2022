﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment // Exemplo de propriedade calculada
        {
            get { return BasicPayment + Tax;}
        }

        public override string ToString()
        {
            return $"Basic payment: {BasicPayment.ToString("f2", CultureInfo.InvariantCulture)}\nTax: " +
                $"{Tax.ToString("f2", CultureInfo.InvariantCulture)}\nTotal payment: {TotalPayment.ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
