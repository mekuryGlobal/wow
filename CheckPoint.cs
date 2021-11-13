using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    public PlayerHealth playerhealth;

    void Start()
    {

        playerhealth = FindObjectOfType<PlayerHealth>();
    }


    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerhealth.CheckPoint(transform.position);
        }
    }
}
