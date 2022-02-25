using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Labb1Generics
{
    public class LådaSameVol : EqualityComparer<Låda>
    {
        public override bool Equals([AllowNull] Låda x, [AllowNull] Låda y)
        {
            if (x.längd*x.bredd*x.höjd==y.längd*y.bredd*y.höjd)
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
