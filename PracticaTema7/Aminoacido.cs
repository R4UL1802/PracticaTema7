using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaTema7
{
    class Aminoacido
    {
        public string _nombre;
        public string _abreviaturaLarga;
        public string _abreviaturaCorta;
        public TipoAminoacido _tipo;
        public int _atomosC;
        public int _atomosH;
        public int _atomosN;
        public int _atomosO;
        public int _atomosS;
        public int _nAtomos;
        public float _pesoMolecular;
        public bool _esEsencial;

        string Nombre
        {
            get
            {
                return _nombre;
            }
        }
        string AbreviaturaLarga
        {
            get
            {
                return _abreviaturaLarga;
            }
        }
        string AbreviaturaCorta
        {
            get
            {
                return _abreviaturaCorta;
            }
        }
        int AtomosC
        {
            get
            {
                return _atomosC;
            }
        }
        int AtomosN
        {
            get
            {
                return _atomosH;
            }
        }
        int AtomosH
        {
            get
            {
                return _atomosN;
            }
        }
        int AtomosO
        {
            get
            {
                return _atomosO;
            }
        }
        int AtomosS
        {
            get
            {
                return _atomosS;
            }
        }
        int Natomos
        {
            get
            {
                return _nAtomos;
            }
        }
        float PesoMolecular
        {
            get
            {
                return _pesoMolecular;
            }
        }
        bool EsEsencial
        {
            get
            {
                return _esEsencial;
            }
        }

        public  Aminoacido(TipoAminoacido tipo)
        {
            _nombre = Enum.GetName(typeof(TipoAminoacido), tipo);
            _abreviaturaLarga = DatosAminoacidos.nombrecorto[tipo];
            _abreviaturaCorta=DatosAminoacidos.letraAminoacido[tipo];
            _pesoMolecular = DatosAminoacidos.peso[tipo];
            _atomosC = DatosAminoacidos.formulas["C",tipo];
            _atomosH =
            _atomosN =
            _atomosO =
            _atomosS = ;
        }
        public override string ToString()
        {
            return $"{_nombre} ({_abreviaturaLarga}, {_abreviaturaCorta}). Peso:{_pesoMolecular}. {_atomosC}, {_atomosN}, " +
                $"{_atomosH}, {_atomosO}, {_atomosS}.";
        }
    }

}
