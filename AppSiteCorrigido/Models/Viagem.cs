using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSiteCorrigido.Models
{
    public class Viagem
    {
        string _origem;
        string _destino;
        double _distancia;
        double _rendimento;
        double _valor_gasolina;

        [AutoIncrement, PrimaryKey]

        public static int id {  get; set; }

        public string Origem { get => _origem; set { if (value == null) throw new Exception("Origem Invalida"); _origem = value; } }
        public string Destino { get => _destino; set { if (value == null) throw new Exception("Destino Invalido"); _destino = value; } }
        public double Distancia { get => _distancia; set { if (value == 0.0) throw new Exception("Distancia Invalida"); _distancia = value; } }
        public double Rendimento { get => _rendimento; set { if (value == 0.0) throw new Exception("Rendimento invalido"); _rendimento = value; } }
        public double Valor_Gasolina {get => _valor_gasolina; set { if (value == 0.0) throw new Exception("Valor do combustivel invalido"); _valor_gasolina = value; } }

    }
}
