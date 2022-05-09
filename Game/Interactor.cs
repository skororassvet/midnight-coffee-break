using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactor : MonoBehaviour
{

    Interactable interactable;
    public LayerMask interactableLayerMask;
    public Image interactImage;
    public Sprite defaultIcon;
    public Sprite defaultInteractIcon;
    public Vector2 defaultIconSize;
    public Vector2 defaultInteractIconSize;

    private void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 4, interactableLayerMask))
        {
           if (hit.collider.GetComponent<Interactable>() != false)
            {
                if (interactable == null || interactable.ID != hit.collider.GetComponent<Interactable>().ID)
                {
                    interactable = hit.collider.GetComponent<Interactable>();               
                }
                if (interactable.interactIcon != null)
                {
                    interactImage.sprite = interactable.interactIcon;
                    if (interactable.iconSize == Vector2.zero)
                    {
                        interactImage.rectTransform.sizeDelta = defaultInteractIconSize;
                    }
                    else
                    {
                        interactImage.rectTransform.sizeDelta = interactable.iconSize;
                    }
                }
                else
                {
                    interactImage.sprite = defaultInteractIcon;
                    interactImage.rectTransform.sizeDelta = defaultInteractIconSize;
                }
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.onInteract.Invoke();
                }
            }
        }
        else
        {
            if(interactImage.sprite != defaultIcon)
            {
                interactImage.sprite = defaultIcon;
                interactImage.rectTransform.sizeDelta = defaultIconSize;
            }
        }
    }
}
