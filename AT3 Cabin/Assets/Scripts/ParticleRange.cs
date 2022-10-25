using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleRange : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private ParticleSystem particleSystems;
    // Update is called once per frame
    private void Awake()
    {
        particleSystems = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if(player != null)
        {

        }
    }
}
