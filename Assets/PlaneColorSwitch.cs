using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneColorSwitch : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Key3")){
          GetComponent<MeshRenderer>().material.color = Color.black;

       } 
       if(Input.GetButtonDown("Key4")){
           GetComponent<MeshRenderer>().material.color = Color.blue;

       }  
    }
}
