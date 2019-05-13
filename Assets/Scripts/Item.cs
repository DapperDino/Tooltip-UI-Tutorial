using UnityEngine;

namespace DapperDino.TooltipUI
{
    public abstract class Item : ScriptableObject
    {
        [SerializeField] private new string name;
        [SerializeField] private int sellPrice;

        public string Name { get { return name; } }
        public abstract string ColouredName { get; }
        public int SellPrice { get { return sellPrice; } }

        public abstract string GetTooltipInfoText();
    }
}