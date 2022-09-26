using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDisplayBonus
{
    private Text _text;

    public UIDisplayBonus(Text label)
    {
        _text = label;
        _text.text = string.Empty;
    }

    public void Display(int value)
    {
        _text.text = $"Score: {value}";
    }
}
