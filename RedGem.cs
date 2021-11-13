using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RedGem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Onyebuchi")
        {
            other.GetComponent<Character>().gems += 5;
            AudioSource source = GetComponent<AudioSource>();
            source.Play();

            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
            Destroy(gameObject, 1.0f);

            

        }
       
    }
}
