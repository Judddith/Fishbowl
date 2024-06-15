using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotbarVisibility : MonoBehaviour
{

    public GameObject button;

    CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("DropdownButton");

        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;

    }

    public void OnDropdown() 
    {
        if (!canvasGroup.interactable) 
        {
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
            canvasGroup.alpha = 1;

            button.SetActive(false);
        }
    }

    public void EndDropdown() 
    {
        if (canvasGroup.interactable)
        {
            canvasGroup.alpha = 0;
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;

            button.SetActive(true);
        }
    }
}
