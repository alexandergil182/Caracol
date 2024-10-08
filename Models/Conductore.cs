using System;
using System.Collections.Generic;

namespace CaracolTanqueos.Models;

public partial class Conductore
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int? IdTipoDocumento { get; set; }

    public string NumeroDocumento { get; set; } = null!;

    public string NumeroTelefono { get; set; } = null!;

    public int? IdEstado { get; set; }

    public virtual Estado? IdEstadoNavigation { get; set; }

    public virtual TiposDocumento? IdTipoDocumentoNavigation { get; set; }

    public virtual ICollection<RegistroTaqueo> RegistroTaqueos { get; set; } = new List<RegistroTaqueo>();
}
