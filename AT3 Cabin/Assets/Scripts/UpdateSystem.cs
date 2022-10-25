using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSystem : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject _camera;

    private Vector3 reachRange;
    private float valueRange = 3.5f;
    private Vector3 idealRangel;

    void Update()
    {
        if(player != null)
        {
            if(transform.position != player.transform.position)
            {
                transform.position = player.transform.position;
            }
        }
        if(_camera != null)
        {
            reachRange = new Vector3(valueRange, 1f, valueRange);
            if (transform.localScale != reachRange)
            {
                idealRangel = reachRange - transform.localScale;
                transform.localScale += idealRangel;
            }
        }
    }

    public void SetRange(float _range)
    {
        valueRange = _range;
    }
}
