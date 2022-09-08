using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class import_cube : MonoBehaviour
{
    public GameObject unity_cube;
 

    public void displayCube(){

        if(unity_cube != null){
            bool isActive = unity_cube.activeSelf;
            unity_cube.SetActive(!isActive);
        }

    }

}
