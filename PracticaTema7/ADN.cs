using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaTema7
{
    public class ADN
    {
        private string _hebra1, _hebra2;
        private int _longitudHebra1, _longitudHebra2;
        private List<Proteina> _proteinas;
        public int Logitud
        {
            get
            {
                return _longitudHebra1;
            }
        }

        public ADN(string hebra1, string hebra2)
        {
            _hebra1 = hebra1;
            _hebra2 = hebra2;
            _longitudHebra1 = _hebra1.Length;
            _longitudHebra2 = _hebra2.Length;
            ComprobarSiCadenaMalCompuesta();
            ComprobarLongitudCadenas();
            ComprobarCadenasComplementarias();
            ComprobarLongitudInsuficiente();
        }
        private void ComprobarSiCadenaMalCompuesta()
        {
            string posicionesMalCompuestaHebra1 = " ";
            string posicionesMalCompuestaHebra2 = " ";
            int longitud = DatosAminoacidos.moleculas.Count;
            for (int i = 0; i < _longitudHebra1; ++i)
            {
                for (int j = 0; j < longitud; ++j)
                {
                    if (_hebra1[i] != DatosAminoacidos.moleculas[j])
                    {
                        posicionesMalCompuestaHebra1 += $" {i},";
                        if (i == _longitudHebra1 - 1)
                        {
                            posicionesMalCompuestaHebra1 += $" {i}";
                        }
                    }
                }
            }
            for (int i = 0; i < _longitudHebra2; ++i)
            {
                for (int j = 0; j < longitud; ++j)
                {
                    if (_hebra2[i] != DatosAminoacidos.moleculas[j])
                    {
                        posicionesMalCompuestaHebra2 += $" {i},";
                        if (i == _longitudHebra2 - 1)
                        {
                            posicionesMalCompuestaHebra2 += $" {i}";
                        }
                    }
                }
            }
            if (posicionesMalCompuestaHebra1.Length > 1 || posicionesMalCompuestaHebra2.Length > 1)
            {
                throw new CadenaMalCompuesta("Las letras de las siguientes posiciones son incorrectas:\n" +
                                                        $"Hebra 1:{posicionesMalCompuestaHebra1}\nHebra 1:{posicionesMalCompuestaHebra1}");
            }
        }
        private void ComprobarLongitudCadenas()
        {
            if (_longitudHebra1 != _longitudHebra2)
            {
                throw new HebrasDeDistintaLongitud($"La primera hebra es de longitud  {_longitudHebra1}\n" +
                                                    $"La segunda hebra es de longitud {_longitudHebra2}");
            }
        }
        private void ComprobarCadenasComplementarias()
        {
            string mensaje = "";

            char molecula1, molecula2;
            //Uso bucle for, para acceder a las dos cadenas al miso tiempo
            for (int i = 0; i < _hebra1.Length; ++i)
            {
                molecula1 = _hebra1[i];
                molecula2 = _hebra2[i];
                if (DatosAminoacidos.moleculasComplementarias[molecula1] != molecula2)
                {
                    mensaje += $"Posicion {i}: Base {molecula1} empareja con {molecula1} " +
                        $"(tendría que ser {DatosAminoacidos.moleculasComplementarias[molecula1]}\n";
                }
            }
            if (mensaje.Length > 1)
            {
                throw new HebrasNoComplementarias(mensaje);
            }
        }
        private void ComprobarLongitudInsuficiente()
        {
            if (_longitudHebra1 < 3)
            {
                throw new LongitudInsuficiente("No tiene suficiente longitud");
            }
        }
        //Como se tiene que volver a construir se tiene tambien que volver a comstruir las lista de aminoacidos
        public   List<Proteina> ObtenerProteinas()
        {
            int[] arrayIndices = new int[2] { -1, 0 };
            List<Proteina> proteinas = new List<Proteina>();
            List<Aminoacido> aminoacidos = ObtenerListaDeAminoacidos(0);
            bool finProteina;
            for (int i = 0; i < aminoacidos.Count; ++i)
            {
                if (TipoAminoacido.STOP == aminoacidos[i]._tipo || i == aminoacidos.Count)
                {
                    arrayIndices[1] = i - 1;
                    arrayIndices[0] = i;
                    proteinas.Add(new Proteina(aminoacidos.GetRange(arrayIndices[0], arrayIndices[1])));
                }
            }
            return proteinas;
        }
        private List<Aminoacido> ObtenerListaDeAminoacidos(int index)
        {
            //
            int indice = (index - _longitudHebra1) / 3 * 3 - 3;
            List<Aminoacido> aminoacidos = new List<Aminoacido>();
            for (int i = index; i < indice; i += 3)
            {
                aminoacidos.Add(new Aminoacido(DatosAminoacidos.codonesAAminoacidos[$"{_hebra1[i]}{_hebra1[i + 1]}{_hebra1[i + 2]}"]));
            }
            return aminoacidos;
        }
    }
}
