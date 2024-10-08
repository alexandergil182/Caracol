using System;
using System.Collections.Generic;

namespace CaracolTanqueos.Models;

public partial class CentrosOrdene
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? CodigoSap { get; set; }

    public int? IdEstado { get; set; }

    public virtual Estado? IdEstadoNavigation { get; set; }

    public virtual ICollection<RegistroTaqueo> RegistroTaqueos { get; set; } = new List<RegistroTaqueo>();
}
