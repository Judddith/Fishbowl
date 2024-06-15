using System.Collections;
using System.Collections.Generic;
using OpenCover.Framework.Model;
using Unity;
using Unity.VisualScripting;
using UnityEngine;
    
public class CloseButton : MonoBehaviour
{

    GameObject hotbar;
    HotbarVisibility visibility;

        
    void Start()
    {
        hotbar = GameObject.Find("Hotbar");
        visibility = hotbar.GetComponent<HotbarVisibility>();
        //gameObject.SetActive(false);
    }

    public void OnClick() 
    {
        visibility.EndDropdown();
    }
}
