using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
public class TriggerRays : MonoBehaviour
{
    public string targetTag;

    public GameObject LeftRayInteractor;
    public GameObject RightRayInteractor;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == targetTag)
        {
            LeftRayInteractor.SetActive(true);
            RightRayInteractor.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag == targetTag)
        {
            LeftRayInteractor.SetActive(false);
            RightRayInteractor.SetActive(false);
            NonNativeKeyboard.Instance.Close();
        }
    }
}
