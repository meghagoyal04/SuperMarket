using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUpObject : MonoBehaviour
{
    public GameObject panel;
    public void OpenPanel()
    {
        if(panel != null)
        {
            panel.SetActive(true);
        }
    }
}
