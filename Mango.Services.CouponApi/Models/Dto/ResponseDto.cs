using System;
namespace Mango.Services.CouponApi.Models.Dto
{
	public class ResponseDto
	{
		public ResponseDto()
		{
			 
		}
        public object? Result { get; set; }
		public bool? IsSuccess { get; set; } = true;
		public string? Message { get; set; } = "";
    }
}

