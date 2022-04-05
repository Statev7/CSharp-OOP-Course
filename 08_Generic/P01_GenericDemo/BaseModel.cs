namespace P01_GenericDemo
{
    using System;

    public class BaseModel
    {
        public BaseModel()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
