using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class MeteorPistol : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem particles;
    public LayerMask layerMask;
    public Transform shootSource;	
    public float distance = 10;
    private bool isShooting = false;

    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(StartShoot);
        grabInteractable.deactivated.AddListener(StopShoot);
    }

    public void StartShoot(ActivateEventArgs args)
    {
        particles.Play();
        isShooting = true;
    }

    public void StopShoot(DeactivateEventArgs args)
    {
        particles.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        isShooting = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isShooting)
        {
            RayscastCheck();
        }
        
    }

    void RayscastCheck()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(shootSource.position, shootSource.forward, out hit, distance, layerMask);
    
        if (hasHit)
        {
            hit.transform.gameObject.SendMessage("Break", SendMessageOptions.DontRequireReceiver);
        }
    }
}
