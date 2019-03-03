﻿namespace EF6CodeFirstDemo
{
    public class StudentAddress
    {
        public int StudentAddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int Postcode { get; set; }

        public virtual Student Student { get; set; }
    }
}