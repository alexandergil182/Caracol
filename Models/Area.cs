using System;
using System.Collections.Generic;

namespace CaracolTanqueos.Models;

public partial class Area
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? IdVicepresidencia { get; set; }

    public int? IdResponsable { get; set; }

    public int? IdEstado { get; set; }

    public virtual Estado? IdEstadoNavigation { get; set; }

    public virtual Responsable? IdResponsableNavigation { get; set; }

    public virtual Vicepresidencia? IdVicepresidenciaNavigation { get; set; }

    public virtual ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
}
