using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressing : MonoBehaviour
{
    public Transform press_handle;
    public Transform handle;
    public Transform machine;
    void Update()
    {
        bool isInserted = machine.GetComponent<Press_Collision>().isInserted;
        bool isSpun = press_handle.GetComponent<Handle_Pressed>().isSpun;

        if (isInserted && isSpun)
        {
            //Transforms pressed handle from a devroom to a machine
            Vector3 pos = new Vector3(-1.589f, 3.745f, -2.175f);
            transform.position = pos;
            Quaternion target = Quaternion.Euler(0f, -30f, 0f);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, 0.1f);

            //Transforms full handle to a devroom
            Vector3 pos1 = new Vector3(-1.5f, -1.1f, -2f);
            handle.transform.position = pos1;
            press_handle.GetComponent<Handle_Pressed>().isSpun = false;
        }
    }
}
