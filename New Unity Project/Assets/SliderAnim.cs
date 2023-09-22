using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations.Rigging;

public class SliderAnim : MonoBehaviour
{
    public TwoBoneIKConstraint twoBoneIKConstraint;
    public Slider slider; 
 



    void Update()
    {

        float sliderValue = slider.value;

        twoBoneIKConstraint.weight = sliderValue;

    }
}