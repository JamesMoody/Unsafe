using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unsafe.Data;

namespace WebApp.bizObjects
{
    public class valCustomChecker : UnsafeValidator<int>
    {
        public valCustomChecker(ref object value) : base(ref value)
        { }

        public override bool isValid
        {
            get
            {
                return false;
            }
        }
    }
}