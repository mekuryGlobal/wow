using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject thirdCamera;
    public GameObject firstCamera;
    public int camMode;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (camMode == 1)
            {
                camMode = 0;
            }
            else
            {
                camMode += 1;
                
            }
            StartCoroutine(CamChange());
        }
    }

    IEnumerator CamChange()
    {
        yield return new WaitForSeconds(0.01f);
        if(camMode == 0)
        {
            thirdCamera.SetActive(true);
            firstCamera.SetActive(false);
        }

        if (camMode == 1)
        {
            firstCamera.SetActive(true);
            thirdCamera.SetActive(false);
            
        }

    }

}

