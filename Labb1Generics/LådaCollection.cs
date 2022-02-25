using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb1Generics
{
    public class LådaCollection : ICollection<Låda>
    {


        public IEnumerator<Låda> GetEnumerator()
        {

            return new LådaEnumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {

            return new LådaEnumerator(this);
        }

        //  inner collection to store objects.
        private List<Låda> innerCol;

        public LådaCollection()
        {
            innerCol = new List<Låda>();
        }

        public int Count
        {
            get
            {
                return innerCol.Count;
            }
        }

        public bool IsReadOnly { get { return false;} }
           
        // Adds an index to the collection.
        public Låda this[int index]
        {
            get { return (Låda)innerCol[index]; }
            set { innerCol[index] = value; }
        }


        public bool Contains(Låda item)
        {
            bool found = false;

            foreach (Låda bx in innerCol)
            {

                if (bx.Equals(item))
                {
                    found = true;
                }
            }

            return found;
        }


        public bool Contains(Låda item, EqualityComparer<Låda> comp)
        {
            bool found = false;

            foreach (Låda bx in innerCol)
            {
                if (comp.Equals(bx, item))
                {
                    found = true;
                }
            }

            return found;
        }

        public void Add(Låda item)
        {
            if (!Contains(item))
            {
                innerCol.Add(item);
            }
            else
            {
                Console.WriteLine("Det finns redan en låda med dimensionerna Höjd: {0} längd: {1} bredd: {2}", item.höjd, item.längd, item.bredd);
            }
         
        }

        public void Clear()
        {
            innerCol.Clear();
        }



        public bool Remove(Låda item)
        {
            bool result = false;

            for (int i= 0; i < innerCol.Count; i++)
            {
                Låda CurrentLåda = (Låda)innerCol[i];

                if (new LådaSameDimensions().Equals(CurrentLåda, item))
                {
                    innerCol.RemoveAt(i);
                    result = true;
                    break;
                }

            }
            return result;
        }

        public void CopyTo(Låda[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
    }
}
