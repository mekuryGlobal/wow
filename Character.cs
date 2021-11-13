using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int gems = 0;

    private GUIStyle guiStyle = new GUIStyle();
    private GUIStyle textColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        guiStyle.fontSize = 30;
        guiStyle.normal.textColor = Color.yellow;

        GUI.contentColor = Color.yellow;
        GUI.Label(new Rect(100, 50, 0, 0), "SkylarToken: " + gems, guiStyle);
    }
}
