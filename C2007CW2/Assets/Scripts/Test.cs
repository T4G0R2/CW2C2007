using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class w : MonoBehaviour
{
    private GameObject RaycastedObj;
    [SerializeField] private int RayLength = 10;
    [SerializeField] private LayerMask LayerMaskInteract;

    [SerializeField] private Image uiCrosshair;

    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if(Physics.Raycast(transform.position, fwd, out hit, RayLength, LayerMaskInteract.value))
        {
            if(hit.collider.CompareTag("Interactable"))
            {
                RaycastedObj = hit.transform.gameObject;

                if (Input.GetKeyDown("e"))
                {
                    Debug.Log("I interacted with " + RaycastedObj.name);
                    Destroy(RaycastedObj);
                }

            }
        }
    }

}
