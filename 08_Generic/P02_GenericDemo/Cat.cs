﻿namespace P02_GenericDemo
{
    public class Cat : BaseModel
    {
        public Cat()
        {

        }

        public Cat(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
