using System;
using System.Collections.Generic;

namespace CaracolTanqueos.Models;

public partial class Vicepresidencia
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? IdEstado { get; set; }

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual Estado? IdEstadoNavigation { get; set; }
}
