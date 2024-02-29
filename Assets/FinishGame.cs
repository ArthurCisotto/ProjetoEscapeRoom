using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public string targetTag;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == targetTag)
        {
            SceneTransitionManager.singleton.GoToSceneAsync(2);
        }
    }

}
