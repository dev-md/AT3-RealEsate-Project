using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPCommand : MonoBehaviour
{
    // Cache the player
    [SerializeField] private GameObject mainObject;

    public void TeleportToObject(GameObject host)
    {
        //Simple Script of inputing a gameobject to teleport to.
        mainObject.transform.position = host.transform.position;
    }
}
