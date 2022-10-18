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

        //Placing all children to the waypoint in editor.
        for (int i = 0; i < waypoints.Count; i++)
        {
            Instantiate(prefab,transform);
        }

        //Getting a Ref of all children.
        for(int i = 0; i < transform.childCount; i++)
        {
            buttonsList.Add(transform.GetChild(i).gameObject); // Add to a list.
        }

        for(int i = 0;i < buttonsList.Count; i++)
        {
            buttonsList[i].name = i.ToString();
            buttonsList[i].transform.GetChild(0).gameObject.GetComponent<Text>().text = waypoints[i].name;
            buttonsList[i].GetComponent<Button>().onClick.AddListener(ButtonFunction);
        }
    }

    public void ButtonFunction()
    {
        transform.parent.gameObject.GetComponent<ToggleScript>().ToggleUI();
        //print(EventSystem.current.currentSelectedGameObject.name);
        int num = Convert.ToInt32(EventSystem.current.currentSelectedGameObject.name);
        GetComponent<TPCommand>().TeleportToObject(waypoints[num]);
    }
}