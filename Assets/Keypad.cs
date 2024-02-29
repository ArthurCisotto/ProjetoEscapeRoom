using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.Experimental.UI;

public class Keypad : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject keypad;
    public GameObject doorHandle;

    // Start is called before the first frame update
    void Start()
    {   
        keypad.SetActive(true);
        NonNativeKeyboard.Instance.InputField = inputField;
        NonNativeKeyboard.Instance.PresentKeyboard(inputField.text);
        //inputField.onValueChanged.AddListener(x => CheckPassword());
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
        if (inputField.text == "5832")
        {
            doorHandle.SetActive(true);
        }
        inputField.text = "";
    }
}
