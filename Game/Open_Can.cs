using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Can : MonoBehaviour
{
    public bool isOpenned = false;
    public int counter = 0;
    public Transform openned_can;
    public Transform lid;

    public void Open(bool status)
    {
        isOpenned = status;
    }

    void Update()
    {
        if (isOpenned && counter <= 1)
        {
            transform.position = new Vector3(3.412f, -3.53f, 21.49f);

            lid.transform.position = new Vector3(5.128f, 3.326f, -12.92101f);

            openned_can.transform.position = new Vector3(4.345f, 3.863f, -12.879f);

            counter++;
        }
    }
}
