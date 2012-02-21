﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace TestLib.Entities
{
public class Car
{
    public int CarId { get; private set; }
    
    [ForeignKey("Car_Brand")]
    public Brand Brand { get; set; }

    [ForeignKey("Brand")]
    public int BrandId { get; private set; }
    
    [Required]
    [StringLength(6)]
    public string RegistrationNumber { get; set; }

    [Column("BodyStyle", TypeName="int")]
    public CarBodyStyle BodyStyle { get; set; }
}
}