using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Paging
    {
        public int Code { get; set; }
        public string Msg { get; set; }
        public int Count { get; set; }
        public List<Supplieslist> Data { get; set; }

        //public static implicit operator Paging(Paging v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
