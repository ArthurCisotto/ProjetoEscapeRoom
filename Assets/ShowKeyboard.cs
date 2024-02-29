using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.Experimental.UI;

public class ShowKeyboard : MonoBehaviour
{   
    public GameObject drawerHandle;
    public GameObject mug;
    public TMP_InputField inputField;

    public NonNativeKeyboard keyboard; 
    // Start is called before the first frame update
    void Start()
    {
        inputField.onSelect.AddListener(x => OpenKeyboard());
        inputField.onValueChanged.AddListener(x => CheckPassword());
        
    }

    public void OpenKeyboard()
    {
        keyboard.InputField = inputField;
        keyboard.PresentKeyboard(inputField.text);
    }

    public void CheckPassword()
    {
        if (inputField.text == "GXq2Cw")
        {
            drawerHandle.SetActive(true);
            mug.SetActive(true);
        }
    }

}
