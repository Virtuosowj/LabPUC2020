using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoderNovo : MonoBehaviour
{
   
    void Update()

    {
  
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Destroy(gameObject);
        }
    }
}
