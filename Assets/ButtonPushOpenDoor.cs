using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPushOpenDoor : MonoBehaviour
{

    public Animator doorAnimator;
    public string boolName = "open";

    // Start is called before the first frame update
    public void OpenDoor()
    {
        bool isOpen = doorAnimator.GetBool(boolName);
        doorAnimator.SetBool(boolName, !isOpen);
    }

}
