using System;
using System.Collections.Generic;

namespace CaracolTanqueos.Models;

public partial class RegistroTaqueo
{
    public int Id { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime FechaTanqueo { get; set; }

    public int? IdVehiculo { get; set; }

    public int? IdConductor { get; set; }

    public int? IdCentroOrden { get; set; }

    public decimal? KilometrajeHoras { get; set; }

    public decimal? GalonesTanqueo { get; set; }

    public decimal ValorTanqueo { get; set; }

    public decimal ValorGalon { get; set; }

    public string? FotosSoporte { get; set; }

    public int? IdEstado { get; set; }

    public DateTime FechaCrea { get; set; }

    public string? UsuarioCrea { get; set; }

    public DateTime? FechaActualiza { get; set; }

    public string? UsuarioActualiza { get; set; }

    public virtual CentrosOrdene? IdCentroOrdenNavigation { get; set; }

    public virtual Conductore? IdConductorNavigation { get; set; }

    public virtual Estado? IdEstadoNavigation { get; set; }

    public virtual Vehiculo? IdVehiculoNavigation { get; set; }
}
