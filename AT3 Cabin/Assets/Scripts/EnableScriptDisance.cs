//Dylan Mount
//13/10/2022

//This Script is for the disance to the camera and the object with the sciprt should be disable

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableScriptDisance : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private GameObject child;
    private void Awake()
    {
        child = transform.GetChild(0).gameObject; // Setting the child
    }

    private void Update()
    {
        //Distance Check
        if(Vector3.Distance(transform.position, player.transform.position) > 3.5)
        {
            child.SetActive(false); //If true, disable the child
        }
        else
        {
            child.SetActive(true); //If false, enable the child
        }
    }

}
