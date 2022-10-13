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
        child = transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) > 5)
        {
            child.SetActive(false);
        }
        else
        {
            child.SetActive(true);
        }
    }

}
