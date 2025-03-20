﻿using System;
using System.Collections.Generic;

namespace PhapClinicX.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? InvoiceId { get; set; }

    public decimal? Amount { get; set; }

    public string? Method { get; set; }

    public string? Status { get; set; }

    public virtual Invoice? Invoice { get; set; }
}
