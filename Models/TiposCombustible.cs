using System;
using System.Collections.Generic;

namespace CaracolTanqueos.Models;

public partial class TiposCombustible
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int? IdEstado { get; set; }

    public virtual Estado? IdEstadoNavigation { get; set; }

    public virtual ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
}
