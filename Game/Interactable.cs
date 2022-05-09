using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent onInteract;
    public int ID;
    public Sprite interactIcon;
    public Vector2 iconSize;
    
    void Start()
    {
        ID = Random.Range(0, 9999999);    
    }

    
    void Update()
    {
        
    }
}
