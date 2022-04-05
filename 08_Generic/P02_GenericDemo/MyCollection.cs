namespace P02_GenericDemo
{
    using System.Collections.Generic;

    public class MyCollection<T>
        where T : BaseModel, new()
    {
        private readonly IList<T> list;

        public MyCollection()
        {
            this.list = new List<T>();
        }

        public void Add(T element)
        {
            this.list.Add(element);
        }
    }
}
