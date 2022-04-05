namespace P01_GenericDemo
{
    using System.Collections.Generic;

    public class MyCollection<TEntity> 
        where TEntity : BaseModel, new()
    {
        private readonly IList<TEntity> list;

        public MyCollection()
        {
            this.list = new List<TEntity>();
        }

        public void Add(TEntity element)
        {
            this.list.Add(element);
            
        }

        public void Remove(TEntity element)
        {
            this.list.Remove(element);
        }
    }
}
