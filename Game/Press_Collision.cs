using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press_Collision : MonoBehaviour
{
    [SerializeField] public bool isInserted = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "full_handle_ct ")
        {
            other.transform.parent.GetComponent<PickUp>().holdingItem = false;
            other.transform.parent.GetComponent<Rigidbody>().useGravity = false;

            //Temporarily turns the collider off
            other.transform.parent.GetComponent<MeshCollider>().enabled = false;

            //Transforms empty handle into a machine
            Vector3 pos = new Vector3(-1.589f, 3.745f, -2.175f);
            other.transform.parent.position = pos;
            Quaternion target = Quaternion.Euler(0f, -30f, 0f);
            other.transform.parent.rotation = Quaternion.Slerp(other.transform.parent.rotation, target, 0.1f);

            other.transform.parent.GetComponent<MeshCollider>().enabled = true;

            isInserted = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        isInserted = false;
    }
}
