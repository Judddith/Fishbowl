using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.Animations;

public class ToggleObjectVisibility : MonoBehaviour
{
    public GameObject objectToToggle;
    //public GameObject parent;

    public void Start()
    {
        //invLeft = GameObject.FindGameObjectWithTag("InventoryLeft").GetComponent<GameObject>();
        objectToToggle = this.gameObject;
    }

    public void ToggleVisibility()
    {
        if (objectToToggle.activeInHierarchy)
        {
            objectToToggle.SetActive(false);
        }
        else
        {
            // for (int i = 0; i < parent.transform.childCount; i++)
            // {
            //     Transform childObject = parent.transform.GetChild(i);
            //     childObject.transform.GetComponent<>() = false;
            // }

            {
               
            }

            //parent.transform.GetChild(1).gameObject.SetActive(true);
            objectToToggle.SetActive(true); ;
        }
    }

    public void DeactivateSiblings()
    {
    Transform parent = gameObject.transform.parent;
    if (parent != null)
    {
        foreach (Transform sibling in parent)
        {
            if (sibling != gameObject.transform)
            {
                sibling.gameObject.SetActive(false);
            }
        }
    }
}
}
