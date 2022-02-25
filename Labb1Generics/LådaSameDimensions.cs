using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Labb1Generics
{
    public class LådaSameDimensions : EqualityComparer<Låda>
    {
        public override bool Equals([AllowNull] Låda x, [AllowNull] Låda y)
        {
            if (x.längd == y.längd && x.höjd == y.höjd && x.bredd == y.bredd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Låda obj)
        {
            throw new NotImplementedException();
        }
    }
}
