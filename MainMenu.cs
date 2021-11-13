using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public Button mainMenu;
    // Start is called before the first frame update 
    void Start()
    {
        Button btn = mainMenu.GetComponent<Button>();
        btn.onClick.AddListener(Menu);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Menu()
    {
       // Application.LoadLevel(Menu);
          
    }
}
