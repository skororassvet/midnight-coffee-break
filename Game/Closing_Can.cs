using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closing_Can : MonoBehaviour
{
    public Transform closed_can;
    public Transform can;
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "can_ct")
        {
            transform.position = new Vector3(3.412f, -3.53f, 21.49f);
            closed_can.transform.position = new Vector3(4.345f, 3.863f, -12.879f);
            can.transform.position = new Vector3(3.412f, -3.53f, 21.49f);

            closed_can.GetComponent<Open_Can>().counter = 0;
            closed_can.GetComponent<Open_Can>().isOpenned = false;
        }
    }
}
