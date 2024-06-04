using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WisdomBar : MonoBehaviour
{
    public Slider slider;
    public void SetMaxWisdom(int wisdom)
    {
        slider.maxValue = wisdom;
        slider.value = wisdom;
    }

    public void SetWisdom(int wisdom)
    {
        slider.value = wisdom;

    }
}
