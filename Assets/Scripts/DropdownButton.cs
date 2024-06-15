using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using Unity;
using Unity.VisualScripting;
using UnityEngine;
    
public class dropdownbutton : MonoBehaviour
{

    GameObject hotbar;
    HotbarVisibility visibility;

        
    void Start()
    {
        hotbar = GameObject.Find("Hotbar");
        visibility = hotbar.GetComponent<HotbarVisibility>();
    }

    public void OnPointerClick()
    { 
        visibility.OnDropdown();
    }

}
