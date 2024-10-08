using System;
using System.Collections.Generic;

namespace CaracolTanqueos.Models;

public partial class Responsable
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int? IdEstado { get; set; }

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual Estado? IdEstadoNavigation { get; set; }
}
