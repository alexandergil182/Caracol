using System;
using System.Collections.Generic;

namespace CaracolTanqueos.Models;

public partial class VwTotal
{
    public DateTime FechaRegistro { get; set; }

    public DateTime FechaTanqueo { get; set; }

    public string? Placa { get; set; }

    public string? Descripcion { get; set; }

    public int? ConsumoEstandar { get; set; }

    public string CentroOrden { get; set; } = null!;

    public string Conductor { get; set; } = null!;

    public string NumeroDocumento { get; set; } = null!;

    public string TipCombustible { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Vice { get; set; } = null!;

    public string Responsable { get; set; } = null!;
}
