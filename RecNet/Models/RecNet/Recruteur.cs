using System;
using System.Collections.Generic;

namespace RecNet.Models.RecNet;

public partial class Recruteur 


{
    public int Id { get; set; }

    public string Nom { get; set; } = String.Empty!;

    public string Email { get; set; } = String.Empty!;

    public string NumTel { get; set; } = String.Empty;

    public string MotDePasse { get; set; } = String.Empty;

    public string? Description { get; set; }

    public virtual ICollection<Offre> Offres { get; set; } = new List<Offre>();
}
