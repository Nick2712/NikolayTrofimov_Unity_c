using System;
using UnityEngine.UI;


namespace NikolayTrofimovUnityC
{
    internal sealed class DisplayBonuses
    {
        private readonly Text _text;


        public DisplayBonuses()
        {
            _text = UnityEngine.Object.FindObjectOfType<Text>();

            if (_text == null) throw new Exception($"UI Text not found {nameof(DisplayBonuses)}");
        }

        public void Display(int value)
        {
            _text.text = $"Вы набрали: {value}";
        }
    }
}
