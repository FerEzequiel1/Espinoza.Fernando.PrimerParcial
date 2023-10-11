﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_de_ingresos
{
    public class Salchicha:Producto
    {
        private int unidades;
        private string tieneChancho;


        public Salchicha(string nombre, string tipo, string marca, int cantidad, float precio, int unidades, string tieneChancho) : base(nombre, tipo, marca, cantidad, precio)
        {
            this.unidades = unidades;
            this.tieneChancho = tieneChancho;
        }
        public Salchicha(string nombre, string tipo, string marca, int cantidad, float precio, int unidades) : this(nombre, tipo, marca, cantidad, precio, unidades, "No")
        {

        }
        public Salchicha(string nombre, string tipo, string marca, int cantidad, float precio) : this(nombre, tipo, marca, cantidad, precio, 6)
        {

        }

        public Salchicha()
        {

        }
        
        public int Unidades { get => unidades; set => unidades = value; }
        public string TieneChancho { get => tieneChancho; set => tieneChancho = value; }


        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.Append($"--- Unidades: {Unidades} --- Contiene chancho: {TieneChancho}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        public override void CalcularTotal()
        {
            Console.WriteLine("asd");
        }
    }
}
