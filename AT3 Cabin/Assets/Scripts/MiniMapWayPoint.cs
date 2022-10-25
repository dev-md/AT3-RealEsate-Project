//Dylan Mount
//25/10/2022

//This script is a lazy making of finding where the player is on the map.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapWayPoint : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject icon;

    private void LateUpdate()
    {
        CheckPoint();
    }

    private void CheckPoint()
    {
        if (icon == null)
        {
            return;
        }
        if (icon.activeSelf == false)
        {
            if (Vector2.Distance(player.transform.position, transform.position) > 0.1f)
            {
                return;
            }
        }
        if (icon.activeSelf == true)
        {
            if (Vector2.Distance(player.transform.position, transform.position) > 0.1f)
            {
                icon.SetActive(false);
                return;
            }
        }

        icon.SetActive(true);
    }
}
