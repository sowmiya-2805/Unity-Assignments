using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public GameObject diamond;


    public void displayDiamond(){
        if(diamond != null){
            bool SetActive = diamond.activeSelf;
            diamond.SetActive(!SetActive);
        }
    }

    void Update()
    {
        diamond.transform.Rotate(new Vector3(0f, 100f, 0f) * Time.deltaTime);
    }
}
