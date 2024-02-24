using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaTema7
{
    public struct Proteina
    {
        private List<Aminoacido> _listaAminoacidos;
        private int _longitud;
        private float _pesoMolecula, _porcentajeEsenciales,
            _porcentajeC, _porcentajeN, _porcentajeH,
            _porcentajeO, _porcentajeS;
        public Proteina(List<Aminoacido> listaAminoacido)
        {
            _longitud = listaAminoacido.Count;
            if (_longitud == 0)
            {
                throw new ProteinaIncorrecta("Lista de aminoacidos vacia");
            }
            _listaAminoacidos = listaAminoacido;
            _pesoMolecula = _porcentajeEsenciales = _porcentajeC = _porcentajeN = _porcentajeH = _porcentajeO = _porcentajeS = 0;
            TipoAminoacido tipoAminoacido;
            foreach (Aminoacido aminoacido in _listaAminoacidos)
            {
                tipoAminoacido = aminoacido._tipo;
                _pesoMolecula += DatosAminoacidos.peso[aminoacido._tipo];
                if (DatosAminoacidos.esencialOnoEsencial[tipoAminoacido])
                {
                    ++_porcentajeEsenciales;
                }
                _porcentajeC += DatosAminoacidos.formulas[tipoAminoacido]["C"];
                _porcentajeH += DatosAminoacidos.formulas[tipoAminoacido]["H"];
                _porcentajeN += DatosAminoacidos.formulas[tipoAminoacido]["N"];
                _porcentajeO += DatosAminoacidos.formulas[tipoAminoacido]["O"];
                _porcentajeS += DatosAminoacidos.formulas[tipoAminoacido]["S"];
            }
            _porcentajeEsenciales *= 100 / _longitud;
            int formulassTotales = (int)(_porcentajeC + _porcentajeH + _porcentajeN + _porcentajeO + _porcentajeS);
            _porcentajeC *= 100 / formulassTotales;
            _porcentajeN *= 100 / formulassTotales;
            _porcentajeH *= 100 / formulassTotales;
            _porcentajeO *= 100 / formulassTotales;
            _porcentajeS *= 100 / formulassTotales;
        }
        public override string ToString()
        {
            return $"Peso: {_pesoMolecula}. Porcentaje de senciales: {_porcentajeEsenciales}." +
                $"(C N H O S): ({_porcentajeC}% {_porcentajeN}% {_porcentajeH}% {_porcentajeO}% {_porcentajeS}% )";
        }
    }

    }

