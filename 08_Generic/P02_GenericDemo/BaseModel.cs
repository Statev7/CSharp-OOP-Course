namespace P02_GenericDemo
{
    using System;

    public abstract class BaseModel
    {
        protected BaseModel()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
