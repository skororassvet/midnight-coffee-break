using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extracting : MonoBehaviour
{
    public Transform button;
    public Transform cup;
    public Transform machine;
    public Transform fake_handle;
    public Transform empty_handle;
    void Update()
    {
        bool isInserted = machine.GetComponent<CoffeeM_Collision>().isInserted;
        bool handlePlaced = machine.GetComponent<CoffeeM_Collision>().handlePlaced;
        bool isSpun = button.GetComponent<Button_Pressed>().isSpun;

        if (isInserted && handlePlaced && isSpun)
        {
            GetComponent<AudioSource>().Play();

            //Transforms full cup from a devroom to a machine
            Vector3 pos = new Vector3(-1.979f, 3.821f, -4.071f);
            transform.position = pos;
            Quaternion target = Quaternion.Euler(0f, -30f, 0f);
            transform.rotation = Quaternion.Slerp(transform.rotation, target, 0.1f);

            //Transforms an empty cup to a devroom
            Vector3 pos1 = new Vector3(6.559f, -3.153f, 23.162f);
            cup.transform.position = pos1;
            button.GetComponent<Button_Pressed>().isSpun = false;

            //Transforms a fake handle to a devroom
            Vector3 pos2 = new Vector3(4.886f, -3.153f, 23.162f);
            fake_handle.transform.position = pos2;

            //Puts an empty handle on a counter
            empty_handle.transform.position = new Vector3 (-1.979f, 3.524f, -3.029f);
        }
    }
}
