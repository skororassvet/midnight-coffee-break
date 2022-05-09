using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grinding : MonoBehaviour
{
    public Transform grinder_handle;
    public Transform handle;
    public Transform machine;
    public Transform can;
    void Update()
    {
        bool isInserted = machine.GetComponent<Grinder_Collision>().isInserted;
        int isSpun = grinder_handle.GetComponent<Handle_Spun>().isSpun;
        bool hasBeans = can.GetComponent<Grinder_Can_Collision>().hasBeans;

        if (isInserted && isSpun >= 7 && hasBeans)
        {
            //Transforms full handle from a devroom to a machine
            Vector3 pos = new Vector3(-1.642f, 3.737f, -0.623f);
            transform.position = pos;
            Quaternion target = Quaternion.Euler(0f, -30f, 0f);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, 0.1f);

            //Transforms empty handle to a devroom
            Vector3 pos1 = new Vector3(6.456f, -3.49f, 21.46f);
            handle.transform.position = pos1;
            grinder_handle.GetComponent<Handle_Spun>().isSpun = 0;
            can.GetComponent<Grinder_Can_Collision>().hasBeans = false;
        }
    }
}
