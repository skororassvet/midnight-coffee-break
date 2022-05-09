using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handle_Pressed : MonoBehaviour
{
    [SerializeField] public bool isSpun = false;
    public Transform machine;
    public void Status(bool status)
    {
        bool isInserted = machine.GetComponent<Press_Collision>().isInserted;
        if (status && isInserted)
        {
            isSpun = true;
        }
    }
}
