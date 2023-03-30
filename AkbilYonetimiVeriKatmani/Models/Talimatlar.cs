﻿using System;
using System.Collections.Generic;

namespace AkbilYonetimiVeriKatmani.Models;

public partial class Talimatlar
{
    public int Id { get; set; }

    public DateTime OlusturulmaTarihi { get; set; }

    public string AkbilId { get; set; } = null!;

    public decimal YuklenecekTutar { get; set; }

    public bool YuklendiMi { get; set; }

    public DateTime? YuklenmeTarih { get; set; }

    public virtual Akbiller Akbil { get; set; } = null!;
}
