using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar_Test : MonoBehaviour
{
    public Text valueText;
    public void OnSliderChanged(float value)
    {
        valueText.text = value.ToString();
    }
}
