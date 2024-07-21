using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShowInvLeft : MonoBehaviour
{
    public GameObject invLeft;

    public void Start()
    {
        //invLeft = GameObject.FindGameObjectWithTag("InventoryLeft").GetComponent<GameObject>();
        invLeft = this.gameObject;
    }

    public void ToggleVisibility()
    {
        if (invLeft.activeInHierarchy)
        {
            invLeft.SetActive(false);
        }
        else
        {
            invLeft.SetActive(true);
        }
    }

    public void ShowActiveItems()
    {
        
    }
}

