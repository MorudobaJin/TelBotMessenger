using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public abstract class BaseValueObjest
    {
        public override bool Equals(object? obj)
        {

            //TODO Разобраться как сравнить
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {/*throw new*/
            return GetHashCode();
        }
    }
}
