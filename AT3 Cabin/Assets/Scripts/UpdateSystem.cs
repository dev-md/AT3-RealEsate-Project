//Dylan Mount
//1/11/2022

//This is a script for updating the particle system at the bottom of the floor
//This is to show the range of the players interaction.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSystem : MonoBehaviour
{
    //Setting fields.
    [SerializeField] GameObject player;
    [SerializeField] GameObject _camera;

    //private vars.
    private Vector3 reachRange;
    private float valueRange = 3.5f;
    private Vector3 idealRangel;

    void Update() //Updated every frame
    {
        if(player != null) // Checking the player is there
        {
            if(transform.position != player.transform.position) //Not the same post
            {
                transform.position = player.transform.position; //update it
            }
        }
        if(_camera != null) //Checking the the camera is there.
        {
            reachRange = new Vector3(valueRange, 1f, valueRange); //Getting the range
            if (transform.localScale != reachRange)//if its not the same
            {
                idealRangel = reachRange - transform.localScale; //get the different
                transform.localScale += idealRangel; //and add it
            }
        }
    }

    public void SetRange(float _range) //This is a called function in the mouse script.
    {
        valueRange = _range;
    }
}
