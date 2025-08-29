using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimal_api.Dominio.ModelViews
{
    public class ErrosDeValidacao
{
    public List<string> Mensagens { get; set; }
    public string? Campo { get; set; }

    // Construtor que inicializa a propriedade não-nula
    public ErrosDeValidacao()
    {
        Mensagens = new List<string>();
    }
}
}