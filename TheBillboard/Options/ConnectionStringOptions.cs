﻿namespace TheBillboard.Options;

using System.ComponentModel.DataAnnotations;

public class ConnectionStringOptions
{
    [Required] public string DefaultDatabase { get; set; } = null!;
}