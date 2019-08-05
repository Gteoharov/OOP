﻿namespace BookShop
{
    using System;
    using System.Text;

    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Title
        {
            get => this.title;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

        public string Author // here may be the problem
        {
            get => this.author;
            set
            {
                int indexOfSpace = value.IndexOf(" ");
                if (indexOfSpace > 0 && indexOfSpace < value.Length - 1 && char.IsDigit(value[indexOfSpace + 1]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                this.author = value;
            }
        }

        public virtual decimal Price
        {
            get => this.price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {this.GetType().Name}")
              .AppendLine($"Title: {this.Title}")
              .AppendLine($"Author: {this.Author}")
              .AppendLine($"Price: {this.Price:f2}");

            string result = sb.ToString().TrimEnd();
            return result;
        }
    }
}