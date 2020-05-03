using System;
using System.Xml.Serialization;

namespace UnitForGame
{
    [Serializable]
    [XmlInclude(typeof(Archer)), XmlInclude(typeof(Soldier)), XmlInclude(typeof(Wizard))]
    public class Unit
    {
        public string UnitName { get; set; }
    }
}
