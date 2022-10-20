//Dylan Mont
//14/10/2022

//This Script will be the teleporting system for the waypoints in the UI

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NavUIWaypoint : MonoBehaviour
{
    //SerializeField vars
    [SerializeField] private GameObject prefab;
    [SerializeField] private List<GameObject> waypoints;
    [SerializeField] private List<GameObject> buttonsList; //Dont Edit, in editor

    private void Start()
    {
        //If you forgot to add all of the waypoints
        if (waypoints == null)
        {
            waypoints = new List<GameObject>();
        }

        //Placing All Child on the Count of waypoints.
        for (int i = 0; i < waypoints.Count; i++)
        {
            Instantiate(prefab,transform); // From a Prefab
            
            //Getting a Ref of all children.
            buttonsList.Add(transform.GetChild(i).gameObject); // Add to a list.

            //Assgining Vars to the children
            buttonsList[i].name = i.ToString(); //Naming the button to the index.
            buttonsList[i].transform.GetChild(0).gameObject.GetComponent<Text>().text = waypoints[i].name;
            buttonsList[i].GetComponent<Button>().onClick.AddListener(ButtonFunction);
        }
    }

    public void ButtonFunction() //The Function click for the button.
    {
        //Toggle the UI
        transform.parent.gameObject.GetComponent<ToggleScript>().ToggleUI();

        //Button depended on teleporting.
        int num = Convert.ToInt32(EventSystem.current.currentSelectedGameObject.name);
        GetComponent<TPCommand>().TeleportToObject(waypoints[num]);

    }
}