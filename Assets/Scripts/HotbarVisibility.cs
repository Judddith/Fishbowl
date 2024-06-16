using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotbarVisibility : MonoBehaviour
{

    public GameObject button;
    public GameObject cross;

    CanvasGroup canvasGroup;
    CanvasGroup toolbarGroup;



    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("DropdownButton");
        cross = GameObject.Find("CloseButton");

        toolbarGroup = GameObject.Find("Toolbar").GetComponent<CanvasGroup>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;

        cross.SetActive(false);
    }

    public void OnDropdown() 
    {
        if (!canvasGroup.interactable) 
        {
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
            canvasGroup.alpha = 1;

            toolbarGroup.interactable = false;
            toolbarGroup.blocksRaycasts = false;
            toolbarGroup.alpha = 0;

            button.SetActive(false);
            cross.SetActive(true);
        }
    }

    public void EndDropdown() 
    {
        if (canvasGroup.interactable)
        {
            canvasGroup.alpha = 0;
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;

            toolbarGroup.alpha = 1;
            toolbarGroup.interactable = true;
            toolbarGroup.blocksRaycasts = true;

            button.SetActive(true);
            cross.SetActive(false);
        }
    }
}
