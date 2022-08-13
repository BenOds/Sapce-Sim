using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform puntoDeMira;

    void Start()
    {
        
    }

    void Update()
    {
        transform.LookAt(puntoDeMira);    
    }


}
