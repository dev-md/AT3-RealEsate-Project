//Dylan Mount
//14/10/2022

// this is a basic script for toggling a script with input

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{

    // All varibles needed for UI toogle
    [SerializeField] private KeyCode _input;
    private GameObject _gameObject;
    private MouseLook _mouseLook;
    private Interaction _mouseInteraction;
    private bool _state = false;

    private void Awake()
    {
        //Caching all varibles with scripts and gameobjects
        _gameObject = transform.GetChild(0).transform.gameObject;
        _mouseLook = Camera.main.GetComponent<MouseLook>();
        _mouseInteraction = Camera.main.GetComponent<Interaction>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(_input)) //If the Key is press
        {
            ToggleUI();
        }
    }

    public void ToggleUI()
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
        _gameObject.SetActive(_state);
    }
}
