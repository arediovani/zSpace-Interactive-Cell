using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnableDisable : MonoBehaviour
{

    public GameObject rightFrame;
    public bool isEnabled = true;

    public Text buttonText;
    public Image buttonIcon;
    public Sprite enableIcon;
    public Sprite disableIcon;
    public void ButtonClicked()
    {
        isEnabled = !isEnabled;
        rightFrame.SetActive(isEnabled);

        if (isEnabled == true)
        {
            // buttonText.text = "Disable";
            buttonIcon.sprite = disableIcon;
        }
        else
        {
            // buttonText.text = "Enable";
            buttonIcon.sprite = enableIcon;
        }
    }
}
