using System;
using System.Collections.Generic;

namespace CaracolTanqueos.Models;

public partial class TiposDocumento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int? IdEstado { get; set; }

    public virtual ICollection<Conductore> Conductores { get; set; } = new List<Conductore>();

    public virtual Estado? IdEstadoNavigation { get; set; }
}
