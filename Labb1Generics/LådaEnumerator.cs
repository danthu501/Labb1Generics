using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb1Generics
{
    public class LådaEnumerator : IEnumerator<Låda>
    {
        private LådaCollection lådaCollection;
        private int Currentindex;
        private Låda CurrentLåda;

        public LådaEnumerator(LådaCollection lådaCollection)
        {
            this.lådaCollection = lådaCollection;
            this.Currentindex = -1;
            this.CurrentLåda = default(Låda);
        }

        public Låda Current
        {
            get { return CurrentLåda; }
        }

        //object IEnumerator.Current => Current;
        object IEnumerator.Current
        {
            get { return Current; }
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (++Currentindex >= lådaCollection.Count)
            {
                return false;
            }
            else
            {
                CurrentLåda = lådaCollection[Currentindex];
            }
            return true;
        }

        public void Reset() {Currentindex = -1;}
        

        void IDisposable.Dispose() { } 
    }
}
