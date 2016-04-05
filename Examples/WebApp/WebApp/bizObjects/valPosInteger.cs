using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unsafe.Data;

namespace WebApp.bizObjects
{
    public class valPosInteger : UnsafeValidator<int>
    {
        private const int minValue = 0;
        private const int maxValue = int.MaxValue;


        public valPosInteger(ref object value) : base(ref value) { }

        public override bool isValid
        {
            get
            {
                int result = 0;

                if (this._unsafeValue.GetType() == typeof(int) && valor.isBetween((int)this._unsafeValue, minValue, maxValue)) {
                    return true;

                } else if (this._unsafeValue.GetType() == typeof(string) && int.TryParse((string)this._unsafeValue, out result) && valor.isBetween(result, minValue, maxValue)) {
                    return true;

                } else {
                    return false;
                }
            }
        }

    }
}