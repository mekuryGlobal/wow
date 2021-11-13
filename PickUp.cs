using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    Animator anim;
    GameManager gameManager;

   

    public bool item;
    public GameObject itemIcon;

    bool pickedUp = false;
    

	// Use this for initialization
	void Start () {
        gameManager = GameObject.FindWithTag("GameUI").GetComponent<GameManager>();
    }
	
	// Update is called once per frame
	void OnTriggerStay(Collider player) {
        if (player.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                pickedUp = true;

                if (item)
                {
                    GameObject i = Instantiate(itemIcon);
                    i.transform.SetParent(gameManager.inventoryTab);

                    Destroy(gameObject);
                }
            }
        }
	}

    
}
