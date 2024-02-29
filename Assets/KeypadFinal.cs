using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.Experimental.UI;

public class KeypadFinal : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject doorHandle;

    public NonNativeKeyboard keypad;
    // Start is called before the first frame update
    void Start()
    {   
        keypad.InputField = inputField;
        keypad.PresentKeyboard(inputField.text);
        inputField.onValueChanged.AddListener(x => CheckIf4Digits());
        
    }

    public void CheckIf4Digits()
    {
        if (inputField.text.Length > 4)
        {
            inputField.text = inputField.text.Substring(0, 4);
        }
    }

    public void CheckPassword()
    {   
        if (inputField.text == "1209")
        {
            doorHandle.SetActive(true);
        }
        inputField.text = "";
    }
}
