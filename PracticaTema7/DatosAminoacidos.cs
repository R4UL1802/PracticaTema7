using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaTema7
{
    public enum TipoAminoacido
    {
        Valina, Leucina, Treonina, Lisina, Triptofano, Histidina,
        Fenilalanina, Isoleucina, Arginina, Metionina, Alanina, Prolina, Glicina, Serina,
        Cisteina, Asparagina, Glutamina, Tirosina, AcidoAspartico, Acidoglutamico, STOP
    }


    public class DatosAminoacidos
    {
        
        public static Dictionary<TipoAminoacido, string> letraAminoacido = new Dictionary<TipoAminoacido, string> {
        {TipoAminoacido.Alanina, "A"},
        };
        public static Dictionary<TipoAminoacido, bool> esencialOnoEsencial = new Dictionary<TipoAminoacido, bool> {
           //esenciales
            {TipoAminoacido.Valina, true },
            {TipoAminoacido.Valina, true},
            {TipoAminoacido.Leucina, true},
            {TipoAminoacido.Treonina, true },
            {TipoAminoacido.Lisina, true},
            {TipoAminoacido.Triptofano, true },
            {TipoAminoacido.Histidina, true },
            {TipoAminoacido.Fenilalanina, true },
            {TipoAminoacido.Isoleucina, true },
            {TipoAminoacido.Arginina, true },
            //ahora los no esenciales
            {TipoAminoacido.Alanina, false },
            /*{TipoAminoacido.Prolina, false },
            {TipoAminoacido.Glicina, false },
            {TipoAminoacido.Serina, false },
            {TipoAminoacido.Cisteina, false },
            {TipoAminoacido.Asparagina, false },
            {TipoAminoacido.Glutamina, false },
            {TipoAminoacido.Tirosina, false },
            {TipoAminoacido.Accido Aspartico, false },
            {TipoAminoacido.Accido Glutamico, false },*/

        };

        public static Dictionary<TipoAminoacido, string> nombresaminoacidos = new Dictionary<TipoAminoacido, string>
        { 
            //En esta primera pon los esenciales
            {TipoAminoacido.Valina, "Valina" },
            {TipoAminoacido.Leucina, "Leucina"},
            {TipoAminoacido.Treonina, "Treonina" },
            {TipoAminoacido.Lisina, "Lisina" },
            {TipoAminoacido.Triptofano, "Triptofano" },
            {TipoAminoacido.Histidina, "Histidina" },
            {TipoAminoacido.Fenilalanina, "Fenilalanina" },
            {TipoAminoacido.Isoleucina, "Isoleucina" },
            {TipoAminoacido.Arginina, "Arginina" },
            //En esta segunda pon no esenciales
            {TipoAminoacido.Alanina, "Alanina" },
            {TipoAminoacido.Prolina, “Prolina”},
            {TipoAminoacido.Glicina, “Glicina”},
            {TipoAminoacido.Serina, “Serina”},
            {TipoAminoacido.Cisteina, “Cisteina”},
            {TipoAminoacido.Asparagina, “Asparagina”},
            {TipoAminoacido.Glutamina, “Glutamina”},
            {TipoAminoacido.Tirosina, “Tirosina”},
            {TipoAminoacido.Accido Aspartico, “AccidoAspartico”},
            {TipoAminoacido.Accido Glutamico, “AccidoGlutamico”},


        };
        public static Dictionary<TipoAminoacido, string> nombrecorto = new Dictionary<TipoAminoacido, string>
        {   //vas poniendo las abreviaturas 
            { TipoAminoacido.Valina, "VAL"},
            {TipoAminoacido.Leucina, "Leu"},
            {TipoAminoacido.Treonina, "Thr" },
            {TipoAminoacido.Lisina, "Lys" },
            {TipoAminoacido.Triptofano, "Trp" },
            {TipoAminoacido.Histidina, "His" },
            {TipoAminoacido.Fenilalanina, "Phe" },
            {TipoAminoacido.Isoleucina, "Ile" },
            {TipoAminoacido.Arginina, "Arg" },
	    {TipoAminoacido.Meteonina, “Met”},
	         //En esta segunda pon no esenciales
            {TipoAminoacido.Alanina, "Ala" },
            {TipoAminoacido.Prolina, “Pro”},
            {TipoAminoacido.Glicina, “Gly”},
            {TipoAminoacido.Serina, “Ser”},
            {TipoAminoacido.Cisteina, “Cys”},
            {TipoAminoacido.Asparagina, “Asn”},
            {TipoAminoacido.Glutamina, “Gln”},
            {TipoAminoacido.Tirosina, “Tyr”},
            {TipoAminoacido.Accido Aspartico, “Asp”},
            {TipoAminoacido.Accido Glutamico, “Glu”},

        };


        public static Dictionary<TipoAminoacido, Dictionary<string, int>> formulas = new Dictionary<TipoAminoacido, Dictionary<string, int>>
        {
            //vas añadiendo mas

            {TipoAminoacido.Alanina, new Dictionary<string, int> { {"C",3} ,{"H",7},{"NO",2}} },
            {TipoAminoacido.Arginina, new Dictionary<string, int> { {"C",6} ,{"H",14},{"N",4}, {"O",2} } },
	    {TipoAminoacido.Valina, new Dictionary<string, int>{ {“C”,5} ,{“H”,11} ,{“ NO”,2 }} },
	    {TipoAminoacido.Leucina, new Dictionary<string, int>{ {“C”,6} ,{“H”,13} ,{“NO”, 2}} },
	    {TipoAminoacido.Treonina, new Dictionary<string, int>{ {“C”,4},{“H”,9},{“NO”,3}} },
	    {TipoAminoacido.Lisina, new Dictionary<string, int>{ {“C”,6},{“H”,14}, {“N”,2 “O”,2}} },
            {TipoAminoacido.Triptofano, new Dictionary<string, int>{ {“C”,11},{“H”, 12},{“N”,2 “O”,2}} },
	    {TipoAminoacido.Histidina, new Dictionary<string, int>{ {“C”,6}{“H”,9},{“N”,3 “O”,2}} },
            {TipoAminoacido.Fenilalanina, new Dictionary<string, int>{ {“C”,9},{“H”,11},{“NO”,2}} },
	    {TipoAminoacido.Isoleucina, new Dictionary<string, int>{ {“C”,6},{“H”,13},{“NO”,2}} },
            {TipoAminoacido.Meteonina, new Dictionary<string, int>{ {“C”,5},{“H”,11},{“NO”,2},{“S”}} },
	    {TipoAminoacido.Prolina, new Dictionary<string, int>{ {“C”,5},{“H”,9},{“NO”,2}} },
	    {TipoAminoacido.Glicina, new Dictionary<string, int>{ {“C”,2},{“H”,5},{“NO”,2}} },
	    {TipoAminoacido.Serina, new Dictionary<string, int>{ {“C”,3},{“H”,7},{“NO”,3}} },
	    {TipoAminoacido.Cisteina, new Dictionary<string, int>{ {“C”,3},{“H”,7},{“NO”,2},{“S”}} },
	    {TipoAminoacido.Asparagina, new Dictionary<string, int>{ {“C”,4},{“H”,8},{“N”,2 “O”,3}} },
	    {TipoAminoacido.Glutamina, new Dictionary<string, int>{ {“C”,5},{“H”,10},{“N”,2 “O”,3}} },
	    {TipoAminoacido.Tirosina, new Dictionary<string, int>{ {“C”,9},{“H”,11},{“NO”,3}} },
	    {TipoAminoacido.Accido Aspartico, new Dictionary<string, int>{ {“C”,4},{“H”,7},{“NO”,4}} },
            {TipoAminoacido.Accido Glutamico, new Dictionary<string, int>{ {“C”,5},{“H”,9},{“NO”,4}} },


        };
        public static Dictionary<TipoAminoacido, float> peso = new Dictionary<TipoAminoacido, float>
        {
            //the same
            {TipoAminoacido.Arginina, 174.20f },
	    {TipoAminoacido.Valina, "119.15f"},
     	    {TipoAminoacido.Leucina, "131.17f"},
            {TipoAminoacido.Treonina, "119.12f" },
      	    {TipoAminoacido.Lisina, "146.19f" },
      	    {TipoAminoacido.Triptofano, "204.23f" },
            {TipoAminoacido.Histidina, "155.15f" },
            {TipoAminoacido.Fenilalanina, "165.19f" },
            {TipoAminoacido.Isoleucina, "131.17f" },
	    {TipoAminoacido.Metionina, “149.21f”},
	    //En esta segunda pon no esenciales
	    {TipoAminoacido.Alanina, 89.09f },
	    {TipoAminoacido.Prolina, “115.13f”},
	    {TipoAminoacido.Glicina, “75.07f”},
	    {TipoAminoacido.Serina, “105.09f”},
	    {TipoAminoacido.Cisteina, “121.16f”},
	    {TipoAminoacido.Asparagina, “132.12f”},
	    {TipoAminoacido.Glutamina, “146.14f”},
	    {TipoAminoacido.Tirosina, “181.19f”},
	    {TipoAminoacido.Accido Aspartico, “133.10f”},
	    {TipoAminoacido.Accido Glutamico, “147.13f”},
        };
    }
}

