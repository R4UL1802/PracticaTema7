using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaTema7
{
    public enum TipoAminoacido
    { Valina, Leucina, Treonina, Lisina, Triptofano, Histidina,
        Fenilalanina, Isoleucina, Arginina, Metionina, Alanina, Prolina, Glicina, Serina,
        Cisteina, Asparagina, Glutamina, Tirosina, AcidoAspartico, Acidoglutamico, STOP }


    class DatosAminoacidos
    {
        public static Dictionary<TipoAminoacido, string> nombresaminoacidos = new Dictionary<TipoAminoacido, string>()
        { 
            //En esta primera pon los esenciales
        {TipoAminoacido.Valina, "Valina" },
        {TipoAminoacido.Leucina, "Leu"},
        {TipoAminoacido.Treonina, "Treonina" },
        {TipoAminoacido.Lisina, "Lisina" },
        {TipoAminoacido.Triptofano, "Triptofano" },
            {TipoAminoacido.Histidina, "Histidina" },
            {TipoAminoacido.Fenilalanina, "Fenilalanina" },
            {TipoAminoacido.Isoleucina, "Isoleucina" },
            {TipoAminoacido.Arginina, "Arginina" },
            //En esta segunda pon no esenciales
            {TipoAminoacido.Alanina, "Alanina" },


        }
        public static Dictionary<TipoAminoacido, string> nombrecorto = new Dictionary<TipoAminoacido, string>()
        {   //vas poniendo las abreviaturas 
            { TipoAminoacido.Valina, "VAL"}, 


} 
        public static Dictionary<TipoAminoacido, >
        }
}
