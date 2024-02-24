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
        public static Dictionary<string, TipoAminoacido> codonesAAminoacidos = new Dictionary<string, TipoAminoacido>
           {
            //Alanina
            {"GCU", TipoAminoacido.Alanina},
            {"GCC", TipoAminoacido.Alanina},
            {"GCA", TipoAminoacido.Alanina},
            {"GCG", TipoAminoacido.Alanina},
            //Leucina
            {"UUA", TipoAminoacido.Leucina},
            {"UUG", TipoAminoacido.Leucina},
            {"CUU", TipoAminoacido.Leucina},
            {"CUC", TipoAminoacido.Leucina},
            {"CUA", TipoAminoacido.Leucina},
            {"CUG", TipoAminoacido.Leucina},
            //Arginina
            {"CGU", TipoAminoacido.Arginina},
            {"CGC", TipoAminoacido.Arginina},
            {"CGA", TipoAminoacido.Arginina},
            {"CGG", TipoAminoacido.Arginina},
            {"AGA", TipoAminoacido.Arginina},
            {"AGG", TipoAminoacido.Arginina},
            //Lisina
            {"AAA", TipoAminoacido.Lisina},
            {"AAG", TipoAminoacido.Lisina},
            //Asparagina
            {"AAU", TipoAminoacido.Asparagina},
            {"AAC", TipoAminoacido.Asparagina},
            //Metionina
            {"AUG", TipoAminoacido.Metionina},
            //AcidoAspartico
            {"GAU", TipoAminoacido.AcidoAspartico},
            {"GAC", TipoAminoacido.AcidoAspartico},
            //Fenilallanina
            {"UUU", TipoAminoacido.Fenilalanina},
            {"UUC", TipoAminoacido.Fenilalanina},
            //Cisteína
            {"UGU", TipoAminoacido.Cisteina},
            {"UGC", TipoAminoacido.Cisteina},
            //Prolina
            {"CCU", TipoAminoacido.Prolina},
            {"CCC", TipoAminoacido.Prolina},
            {"CCA", TipoAminoacido.Prolina},
            {"CCG", TipoAminoacido.Prolina},
            //Glutamina
            {"CAA", TipoAminoacido.Glutamina},
            {"CAG", TipoAminoacido.Glutamina},
            //Serina
            {"UCU", TipoAminoacido.Serina},
            {"UCC", TipoAminoacido.Serina},
            {"UCA", TipoAminoacido.Serina},
            {"UCG", TipoAminoacido.Serina},
            {"AGU", TipoAminoacido.Serina},
            {"AGC", TipoAminoacido.Serina},
            //AcidoGlutamico
            {"GAA", TipoAminoacido.Acidoglutamico},
            {"GAG", TipoAminoacido.Acidoglutamico},
            //Treonina
            {"ACU", TipoAminoacido.Treonina},
            {"ACC", TipoAminoacido.Treonina},
            {"ACA", TipoAminoacido.Treonina},
            {"ACG", TipoAminoacido.Treonina},
            //Glicina
            {"GGU", TipoAminoacido.Glicina},
            {"GGC", TipoAminoacido.Glicina},
            {"GGA", TipoAminoacido.Glicina},
            {"GGG", TipoAminoacido.Glicina},
            //Triptófano
            {"UGG", TipoAminoacido.Triptofano},
            //Histidina
            {"CAU", TipoAminoacido.Histidina},
            {"CAC", TipoAminoacido.Histidina},
            //Tirosina
            {"UAU", TipoAminoacido.Tirosina},
            {"UAC", TipoAminoacido.Tirosina},
            //Isoleucina
            {"AUU", TipoAminoacido.Isoleucina},
            {"AUC", TipoAminoacido.Isoleucina},
            {"AUA", TipoAminoacido.Isoleucina},
            //Valina
            {"GUU", TipoAminoacido.Valina},
            {"GUC", TipoAminoacido.Valina},
            {"GUA", TipoAminoacido.Valina},
            {"GUG", TipoAminoacido.Valina},
            //STOP
            {"UAG", TipoAminoacido.STOP},
            {"UGA", TipoAminoacido.STOP},
            {"UAA", TipoAminoacido.STOP}
           };
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
            {TipoAminoacido.Prolina, false },
            {TipoAminoacido.Glicina, false },
            {TipoAminoacido.Serina, false },
            {TipoAminoacido.Cisteina, false },
            {TipoAminoacido.Asparagina, false },
            {TipoAminoacido.Glutamina, false },
            {TipoAminoacido.Tirosina, false },
            {TipoAminoacido.AcidoAspartico, false },
            {TipoAminoacido.Acidoglutamico, false },

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
            {TipoAminoacido.Prolina, "Prolina"},
            {TipoAminoacido.Glicina, "Glicina"},
            {TipoAminoacido.Serina, "Serina"},
            {TipoAminoacido.Cisteina, "Cisteina"},
            {TipoAminoacido.Asparagina, "Asparagina"},
            {TipoAminoacido.Glutamina, "Glutamina"},
            {TipoAminoacido.Tirosina, "Tirosina"},
            {TipoAminoacido.AcidoAspartico, "AccidoAspartico"},
            {TipoAminoacido.Acidoglutamico, "AccidoGlutamico"},


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
	    {TipoAminoacido.Metionina, "Met"},
	         //En esta segunda pon no esenciales
            {TipoAminoacido.Alanina, "Ala" },
            {TipoAminoacido.Prolina, "Pro"},
            {TipoAminoacido.Glicina, "Gly"},
            {TipoAminoacido.Serina, "Ser"},
            {TipoAminoacido.Cisteina, "Cys"},
            {TipoAminoacido.Asparagina, "Asn"},
            {TipoAminoacido.Glutamina, "Gln"},
            {TipoAminoacido.Tirosina, "Tyr"},
            {TipoAminoacido.AcidoAspartico, "Asp"},
            {TipoAminoacido.Acidoglutamico, "Glu"},

        };


        public static Dictionary<TipoAminoacido, Dictionary<string, int>> formulas = new Dictionary<TipoAminoacido, Dictionary<string, int>>
        {
            //vas añadiendo mas

            {TipoAminoacido.Alanina, new Dictionary<string, int> { {"C",3} ,{"H",7},{"NO",2}} },
            {TipoAminoacido.Arginina, new Dictionary<string, int> { {"C",6} ,{"H",14},{"N",4}, {"O",2} } },
	    {TipoAminoacido.Valina, new Dictionary<string, int>{ {"C",5} ,{"H",11} ,{" NO",2 }} },
	    {TipoAminoacido.Leucina, new Dictionary<string, int>{ {"C",6} ,{"H",13} ,{"NO", 2}} },
	    {TipoAminoacido.Treonina, new Dictionary<string, int>{ {"C",4},{"H",9},{"NO",3}} },
	    {TipoAminoacido.Lisina, new Dictionary<string, int>{ {"C",6},{"H",14}, { "N", 2 }, {"O",2}} },
            {TipoAminoacido.Triptofano, new Dictionary<string, int>{ {"C",11},{"H", 12},{ "N", 2 }, {"O",2}} },
	    {TipoAminoacido.Histidina, new Dictionary<string, int>{ {"C",6},{"H",9},{ "N", 3 }, {"O",2}} },
            {TipoAminoacido.Fenilalanina, new Dictionary<string, int>{ {"C",9},{"H",11},{"NO",2}} },
	    {TipoAminoacido.Isoleucina, new Dictionary<string, int>{ {"C",6},{"H",13},{"NO",2}} },
            {TipoAminoacido.Metionina, new Dictionary<string, int>{ {"C",5},{"H",11},{"NO",2},{"S",0}} },
	    {TipoAminoacido.Prolina, new Dictionary<string, int>{ {"C",5},{"H",9},{"NO",2}} },
	    {TipoAminoacido.Glicina, new Dictionary<string, int>{ {"C",2},{"H",5},{"NO",2}} },
	    {TipoAminoacido.Serina, new Dictionary<string, int>{ {"C",3},{"H",7},{"NO",3}} },
	    {TipoAminoacido.Cisteina, new Dictionary<string, int>{ {"C",3},{"H",7},{"NO",2},{"S",0}} },
	    {TipoAminoacido.Asparagina, new Dictionary<string, int>{ {"C",4},{"H",8},{ "N", 2 }, {"O",3}} },
	    {TipoAminoacido.Glutamina, new Dictionary<string, int>{ {"C",5},{"H",10},{ "N", 2 }, {"O",3}} },
	    {TipoAminoacido.Tirosina, new Dictionary<string, int>{ {"C",9},{"H",11},{"NO",3}} },
	    {TipoAminoacido.AcidoAspartico, new Dictionary<string, int>{ {"C",4},{"H",7},{"NO",4}} },
            {TipoAminoacido.Acidoglutamico, new Dictionary<string, int>{ {"C",5},{"H",9},{"NO",4}} },


        };
        public static Dictionary<TipoAminoacido, float> peso = new Dictionary<TipoAminoacido, float>
        {
            //the same
            {TipoAminoacido.Arginina, 174.20f },
	    {TipoAminoacido.Valina, 119.15f},
     	    {TipoAminoacido.Leucina, 131.17f},
            {TipoAminoacido.Treonina, 119.12f },
      	    {TipoAminoacido.Lisina, 146.19f },
      	    {TipoAminoacido.Triptofano, 204.23f },
            {TipoAminoacido.Histidina, 155.15f },
            {TipoAminoacido.Fenilalanina, 165.19f },
            {TipoAminoacido.Isoleucina, 131.17f },
	    {TipoAminoacido.Metionina, 149.21f},
	    //En esta segunda pon no esenciales
	    {TipoAminoacido.Alanina, 89.09f },
	    {TipoAminoacido.Prolina, 115.13f},
	    {TipoAminoacido.Glicina, 75.07f},
	    {TipoAminoacido.Serina, 105.09f},
	    {TipoAminoacido.Cisteina, 121.16f},
	    {TipoAminoacido.Asparagina, 132.12f},
	    {TipoAminoacido.Glutamina, 146.14f},
	    {TipoAminoacido.Tirosina, 181.19f},
	    {TipoAminoacido.AcidoAspartico, 133.10f},
	    {TipoAminoacido.Acidoglutamico, 147.13f},
        };
        public static List<char> moleculas = new List<char> { 'A', 'T', 'G', 'C' };
        public static Dictionary<char, char> moleculasComplementarias = new Dictionary<char, char>
        {
            { 'A', 'T'},
            { 'T', 'A'},
            { 'G', 'C'},
            { 'C', 'G'},
        };
    }
    
}

