//Dylan Mont
//14/10/2022

//This Script will be the teleporting system for the waypoints in the UI


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavUIWaypoint : MonoBehaviour
{
    [SerializeField] private List<GameObject> waypoints;
    private List<Button> buttonList;

    private void Awake()
    {
        //If you forgot to add all of the waypoints
        if(waypoints == null)
        {
            waypoints = new List<GameObject>();
        }
    }

    private void Start()
    {
        for(int i = 0; i < waypoints.Count; i++)
        {
            //buttonList[i] = Instantiate()
        }
    }
}
