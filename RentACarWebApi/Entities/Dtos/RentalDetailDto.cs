﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class RentalDetailDto
    {
        public int RentalId { get; set; }
        
        public string BrandName { get; set; }
        
        public string ColorName { get; set; }
        public string CompanyName { get; set; }
        public string UserName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
