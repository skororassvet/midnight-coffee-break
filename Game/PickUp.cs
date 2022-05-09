using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform dest;
    public bool holdingItem = false;

    public void TakeItem(bool var)
    {
        holdingItem = var;
    }

    void Update()
    {

        if (holdingItem == true)
        {
            //audio.Play();
            GetComponent<MeshCollider>().enabled = false;
            GetComponent<Rigidbody>().useGravity = false;
            transform.position = dest.position;
            transform.parent = GameObject.Find("Destination").transform;

            Quaternion target = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, 0.1f);
        }

        if (holdingItem == false)
        {
            GetComponent<MeshCollider>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
            transform.parent = null;         

            Quaternion target = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, 0.1f);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            holdingItem = false;
        }
    }
}
