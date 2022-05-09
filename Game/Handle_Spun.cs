using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handle_Spun : MonoBehaviour
{
    [SerializeField] public int isSpun = 0;
    public Transform machine;
    public void Status (bool status)
    {
        bool isInserted = machine.GetComponent<Grinder_Collision>().isInserted;
        if (status && isInserted)
        {
            isSpun++;
        }
    }
}
