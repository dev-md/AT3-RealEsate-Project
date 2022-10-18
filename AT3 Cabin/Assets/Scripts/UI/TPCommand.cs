using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPCommand : MonoBehaviour
{
    // Cache the player
    [SerializeField] private GameObject mainObject;

    public void TeleportToObject(GameObject _gameObject)
    {
        //Simple Script of inputing a gameobject to teleport to.
        mainObject.transform.position = _gameObject.transform.position;
    }
}
