using System;
using System.Collections.Generic;

namespace CaracolTanqueos.Models;

public partial class Estado
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public bool FlagActivo { get; set; }

    public virtual ICollection<Area> Areas { get; set; } = new List<Area>();

    public virtual ICollection<CentrosOrdene> CentrosOrdenes { get; set; } = new List<CentrosOrdene>();

    public virtual ICollection<Conductore> Conductores { get; set; } = new List<Conductore>();

    public virtual ICollection<RegistroTaqueo> RegistroTaqueos { get; set; } = new List<RegistroTaqueo>();

    public virtual ICollection<Responsable> Responsables { get; set; } = new List<Responsable>();

    public virtual ICollection<TiposCombustible> TiposCombustibles { get; set; } = new List<TiposCombustible>();

    public virtual ICollection<TiposDocumento> TiposDocumentos { get; set; } = new List<TiposDocumento>();

    public virtual ICollection<TiposEquipo> TiposEquipos { get; set; } = new List<TiposEquipo>();

    public virtual ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();

    public virtual ICollection<Vicepresidencia> Vicepresidencia { get; set; } = new List<Vicepresidencia>();
}
