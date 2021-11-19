using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Advanced.Factory.ZooManagement.Animals
{
    public abstract class Animal
    {
        public abstract string _ID { get; set; }
        public abstract string _name { get; set; }
        public abstract int _legs { get; set; }
        public abstract float _weight { get; set; }
        public abstract string _action { get; set; }
        public abstract string _feature { get; set; }
        public virtual string? _color { get; set; }
        public virtual int? _swing { get; set; }

        public Animal()
        {

        }

        public Animal(string ID, string name, int legs, float weight, string action, string feature, string? color, int? swing)
        {
            _ID = ID;
            _name = name;
            _legs = legs;
            _weight = weight;
            _action = action;
            _feature = feature;
            if (String.IsNullOrEmpty(color))
                _color = color;
            if (swing is not null || swing > 0)
                _swing = swing;
        }

        public abstract void Print();
    }
    public class LeggedAnimal : Animal
    {
        public LeggedAnimal(string iD, string name, float weight, string feature, string action, string? color, bool isFourLegged = true)
        {
            _ID = iD;
            _name = name;
            if (isFourLegged)
                _legs = 4;
            else
                _legs = 0;
            _weight = weight;
            _feature = feature;
            _action = action;
            _color = color;
        }

        public override string _ID { get; set; }

        public override string _name { get; set; }

        public override int _legs { get; set; }

        public override float _weight { get; set; }


        public override string _feature { get; set; }

        public override string _action { get; set; }

        public override string? _color { get; set; }

        public override void Print()
        {
            Console.WriteLine($"ID: {_ID}\nName: {_name}\nLegs: {_legs}\nWeight: {_weight}" +
                $"\nFeatures: {_feature}\nActions: {_action}\nColors: {_color}");
        }
    }
    public class BidepalAnimal : Animal
    {
        public override string _ID
        { get; set; }
        public override string _name
        { get; set; }
        public override int _legs
        { get; set; }
        public override float _weight
        { get; set; }

        public override string _feature
        { get; set; }

        public override string _action
        { get; set; }

        public override string? _color
        { get; set; }
        public override int? _swing
        { get; set; }

        public BidepalAnimal(string ID, string name, float weight, string feature, int legs, string action, string? color, int? swing)
        {
            _ID = ID;
            _name = name;
            _legs = legs;
            _weight = weight;
            _feature = feature;
            _action = action;
            _swing = swing.Value;
            if (color is not null)
                _color = color;
        }

        public override void Print()
        {
            if (_color is not null)
            {
                Console.WriteLine($"ID: {_ID}\nName: {_name}\nLegs: {_legs}\nWeight: {_weight}" +
                $"\nFeatures: {_feature}\nActions: {_action}\nColor: {_color}"
                + $"\nWings: {_swing}");
            }
            else
            {
                Console.WriteLine($"ID: {_ID}\nName: {_name}\nLegs: {_legs}\nWeight: {_weight}" +
                $"\nFeatures: {_feature}\nActions: {_action}"
                + $"\nWings: {_swing}");
            }
        }
    }
}