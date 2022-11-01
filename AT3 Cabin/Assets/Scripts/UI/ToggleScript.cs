//Dylan Mount
//14/10/2022

// this is a basic script for toggling a script with input
// edit, i made this messer by adding a case for checking for a button type.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{

    // All varibles needed for UI toogle
    [SerializeField] private KeyCode _input;
    private MouseLook _mouseLook;
    private Interaction _mouseInteraction;
    private bool _state = false;

    [SerializeField] private List<GameObject> _objectsList;

    private void Awake()
    {
        //Caching all varibles with scripts and gameobjects
        _mouseLook = Camera.main.GetComponent<MouseLook>();
        _mouseInteraction = Camera.main.GetComponent<Interaction>();

        if(_input == KeyCode.Mouse2) //Seeing if its middle mouse
        {
            _state = true; // We want to start enable.
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(_input == KeyCode.Mouse1) //Checking if its right click.
        {
            if (Input.GetKeyDown(_input)) //If the Key is press
            {
                ToggleUI();
            }
        }
        //Checking if its middle mouse and having some objects to disable.
        else if ((_input == KeyCode.Mouse2) && (_objectsList.Count > 0))
        {
            if (Input.GetKeyDown(_input)) //If the Key is press
            {
                RangeToggleUI();
            }
        }

    }

    public void ToggleUI() //For the waypoint menu
    {
        //Go into the Toggle Switch
        if (_state == false)
        {
            _state = true; //Switch the state
            _mouseLook.ToggleMouseLook(false, true); //Disable Mouse lock
        }
        else if (_state == true)
        {
            _state = false;
            _mouseLook.ToggleMouseLook(true, true); //Enable Mouse lock
        }

        //Finish with the state varible to enable or disable scripts and objects.
        _mouseInteraction.enabled = !_state;
        
        //Cycle through children and disable or enable them
        foreach(Transform child in transform)
        {
            child.gameObject.SetActive(_state);
        }
    }

    public void RangeToggleUI() //For the range menu and parictle
    {
        //Go into the Toggle Switch
        if (_state == false)
        {
            _state = true; //Switch the state
        }
        else if (_state == true)
        {
            _state = false;
        }

        //Cycle through children and disable or enable them
        foreach (GameObject child in _objectsList)
        {
            child.gameObject.SetActive(_state);
        }
    }
}
