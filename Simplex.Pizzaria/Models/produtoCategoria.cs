﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Simplex.Pizzaria.Models
{
    public class produtoCategoria : SimpleX.Model.produtoCategoria
    {
        public empresa empresa { get; set; }

    }
}