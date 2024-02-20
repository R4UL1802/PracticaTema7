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
            /*{TipoAminoacido.Prolina, “Prolina”},
            {TipoAminoacido.Glicina, “Glicina”},
            {TipoAminoacido.Serina, “Serina”},
            {TipoAminoacido.Cisteina, “Cisteina”},
            {TipoAminoacido.Asparagina, “Asparagina”},
            {TipoAminoacido.Glutamina, “Glutamina”},
            {TipoAminoacido.Tirosina, “Tirosina”},
            {TipoAminoacido.Accido Aspartico, “AccidoAspartico”},
            {TipoAminoacido.Accido Glutamico, “AccidoGlutamico”},*/


        };
        public static Dictionary<TipoAminoacido, string> nombrecorto = new Dictionary<TipoAminoacido, string>
        {   //vas poniendo las abreviaturas 
            { TipoAminoacido.Valina, "VAL"},
        };


        public static Dictionary<TipoAminoacido, Dictionary<string, int>> formulas = new Dictionary<TipoAminoacido, Dictionary<string, int>>
        {
            //vas añadiendo mas

            {TipoAminoacido.Alanina, new Dictionary<string, int> { {"C",3} ,{"H",7},{"NO",2}} },
            {TipoAminoacido.Arginina, new Dictionary<string, int> { {"C",6} ,{"H",14},{"N",4}, {"O",2} } },

        };
        public static Dictionary<TipoAminoacido, float> peso = new Dictionary<TipoAminoacido, float>
        {
            //the same
            {TipoAminoacido.Alanina, 89.09f },
            {TipoAminoacido.Arginina, 174.20f },
        };
    }
}

