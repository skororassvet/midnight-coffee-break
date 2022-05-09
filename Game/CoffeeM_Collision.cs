using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeM_Collision : MonoBehaviour
{
    [SerializeField] public bool isInserted = false;
    [SerializeField] public bool handlePlaced = false;
    public Transform fake_handle;
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "cup_ct")
        {
            other.transform.parent.GetComponent<PickUp>().holdingItem = false;
            other.transform.parent.GetComponent<Rigidbody>().useGravity = false;

            //Temporarily turns the collider off
            other.transform.parent.GetComponent<MeshCollider>().enabled = false;

            //Transforms empty cup into a machine
            Vector3 pos = new Vector3(-1.979f, 3.821f, -4.071f);
            other.transform.parent.position = pos;

            other.transform.parent.GetComponent<MeshCollider>().enabled = true;

            isInserted = true;
        }

        if (other.name == "pressed_handle_ct ")
        {
            //Transforms a handle into a dev shed
            other.transform.parent.GetComponent<PickUp>().holdingItem = false;
            Vector3 pos1 = new Vector3(-2f, -1.1f, -2f);
            other.transform.parent.position = pos1;

            //Transforms a fake handle into a machine
            Vector3 pos = new Vector3(-1.95f, 4.156f, -4.075f);
            fake_handle.transform.position = pos;

            handlePlaced = true;
        }
    }
}
