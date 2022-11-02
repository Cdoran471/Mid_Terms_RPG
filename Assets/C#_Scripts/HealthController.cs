using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public Text valueText;
    int health = 5;
    public Slider slider;
    public void OnSliderChanged(float value)
    {
        valueText.text = value.ToString();
    }
    public void UpdateProgress()
    {
        health-= health;
        slider.value = health;
    }
}
