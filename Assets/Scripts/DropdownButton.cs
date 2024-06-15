using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using Unity;
using Unity.VisualScripting;
using UnityEngine;
    
public class dropdownbutton : MonoBehaviour
{

    public GameObject hotbar;
    public HotbarVisibility visibility;

        
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
