using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grinder_Can_Collision : MonoBehaviour
{
    [SerializeField] private Transform machine;
    [SerializeField] public bool hasBeans = false;
    [SerializeField] private AudioSource source;
    [SerializeField] private Animator animator;
    [SerializeField] private string boolname;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "grinder_ct")
        {
            hasBeans = true;
            source.Play();

            animator.SetBool(boolname, !animator.GetBool(boolname));
        }
    }
}
