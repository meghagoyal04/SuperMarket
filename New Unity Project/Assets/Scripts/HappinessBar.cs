using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappinessBar : MonoBehaviour
{
    public Image happinessbar;
    public void UpdateHappiness(float fraction)
    {
        happinessbar.fillAmount = fraction;
    }
}
