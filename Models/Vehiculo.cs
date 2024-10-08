using System;
using System.Collections.Generic;

namespace CaracolTanqueos.Models;

public partial class Vehiculo
{
    public int Id { get; set; }

    public int? IdArea { get; set; }

    public int? IdTipo { get; set; }

    public string? Placa { get; set; }

    public string? Descripcion { get; set; }

    public int? ConsumoEstandar { get; set; }

    public int? IdTipoCombustible { get; set; }

    public int? IdEstado { get; set; }

    public virtual Area? IdAreaNavigation { get; set; }

    public virtual Estado? IdEstadoNavigation { get; set; }

    public virtual TiposCombustible? IdTipoCombustibleNavigation { get; set; }

    public virtual TiposEquipo? IdTipoNavigation { get; set; }

    public virtual ICollection<RegistroTaqueo> RegistroTaqueos { get; set; } = new List<RegistroTaqueo>();
}
