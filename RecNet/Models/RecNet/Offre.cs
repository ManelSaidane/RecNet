using System;
using System.Collections.Generic;

namespace RecNet.Models.RecNet;

public partial class Offre
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Salaire { get; set; }

    public bool Statu { get; set; }

    public string Localisation { get; set; } = null!;

    public int IdRecruteur { get; set; }

    public virtual Recruteur IdRecruteurNavigation { get; set; } = null!;
}
