﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Mango.Services.CouponApi.Models.Dto
{
	public class CouponDto
	{ 
        public int CouponId { get; set; }
         public string CouponCode { get; set; }
         public int DiscountAmount { get; set; }
        public int MinAmount { get; set; }
    }


}

