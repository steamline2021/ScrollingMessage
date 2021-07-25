using System;
using System.Collections.Generic;
using System.Text;

namespace ScrollingMessage
{
    public class Composite: IComponent
    {
        public string Name { get; set; }
        List<IComponent> components = new List<IComponent>();

        public Composite(string name)
        {
            this.Name = name;
        }

        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void DisplayPrice()
        {
            Console.WriteLine(Name);
            foreach (var item in components)
            {
                item.DisplayPrice();
            }
        }

        public string GetPrice()
        {
            StringBuilder sb = null;
            foreach (var item in components)
            {
                sb.Append(item.ToString());
            }
            return sb.ToString();

        }
    }
}
