using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{


    void Start()
    {

    }


    void Update()
    {

    }

    public void Clicked()
    {
        FindObjectOfType<PlayerHealth>().SelectedContinue();
        gameObject.SetActive(false);
    }
}
