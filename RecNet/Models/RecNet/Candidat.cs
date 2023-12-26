using System;
using System.Collections.Generic;

namespace RecNet.Models.RecNet;

public partial class Candidat
{
    public int Id { get; set; }

    public string NomEtPrenom { get; set; } = String.Empty ;

    public string Email { get; set; } = String.Empty;

    public string NumTel { get; set; } = String.Empty;

    public string MotDePasse { get; set; } = String.Empty;

    public string ParcoursEducatif { get; set; } = String.Empty;

    public string Experience { get; set; } = String.Empty;

    public int Age { get; set; }
}
