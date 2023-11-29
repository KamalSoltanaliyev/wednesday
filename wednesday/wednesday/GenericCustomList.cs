namespace wednesday
{
    public class GenericCustomList<T> where T : new()
    {
        public T[] array;
        public int Count { get; set; }
        public int Capacity { get; set; }  = 0;

        public GenericCustomList()
        {
            
        }

        public GenericCustomList(int count, int capacity)
        {
            array = new T[0];
            Count = count;
            Capacity = capacity;
        }

        public void Add(T item)
        { 
            
        }
        public T Find(Predicate<T> match)
        {
            foreach (T item in array)
            {
                if (match(item))
                    return item;
            }
            return default(T);
        }

        public GenericCustomList<T> FindAll(Predicate<T> match)
        {
            GenericCustomList<T> result = new GenericCustomList<T>();
            foreach (T item in array)
            {
                if (match(item))
                    result.Add(item);
            }
            return result;
        }

        public bool Contains(T item)
        {
            foreach (T i in array)
            {
                if (object.Equals(i, item))
                    return true;
            }
            return false;
        }

        public bool Exists(Predicate<T> match)
        {
            foreach (T item in array)
            {
                if (match(item))
                    return true;
            }
            return false;
        }

        public void Remove(T item)
        {
        //    int index = Array.IndexOf(array, item);
        //    if (index != -1)
        //    {
        //        Array.Copy(array, index + 1, array, index, count - index - 1);
        //        count--;
        //    }
        }
    }

}

