﻿using System;
using System.Collections.Generic;

namespace PhapClinicX.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public int? CategoryId { get; set; }

    public string? ProductName { get; set; }

    public decimal? Price { get; set; }

    public string? Image { get; set; }

    public string? Description { get; set; }

    public string? Specifications { get; set; }

    public string? Warranty { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ProductCategory? Category { get; set; }

    public virtual ICollection<ProductComment> ProductComments { get; set; } = new List<ProductComment>();
}
