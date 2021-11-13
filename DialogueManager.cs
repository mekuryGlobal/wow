using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public NPC npc;
    bool isTalking = false;

    float distance;
    float curResponseTracker = 0;

    public GameObject player;
    public GameObject teacher;
    public GameObject dialogueUI;

    public Text npcName;
    public Text npcDialogueBox;
    public Text playerResponse; 

    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    private void OnSpeak()  
    {
        distance = Vector3.Distance(player.transform.position, teacher.transform.position);
        if (distance <= 2.5f)
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0f)
            {
                curResponseTracker++;
                if(curResponseTracker >= npc.playerDialogue.Length - 1)
                {
                    curResponseTracker = npc.playerDialogue.Length - 1;
                }
                else if(Input.GetAxis("Mouse ScrollWheel") > 0f)
                {
                    curResponseTracker--;
                    if(curResponseTracker < 0)
                    {
                        curResponseTracker = 0;
                    }
                }
            }

            if (Input.GetKeyDown(KeyCode.N) && isTalking == false)
            {
                StartConversation();
            }
            else if(Input.GetKeyDown(KeyCode.N) && isTalking == true)
            {
                EndDialogue();
            }

            if (curResponseTracker == 0 && npc.playerDialogue.Length >= 0)
            {
                playerResponse.text = npc.playerDialogue[0];

                if (Input.GetKeyDown(KeyCode.Return))
                {
                    npcDialogueBox.text = npc.dialogue[1];
                }

            }
            else if(curResponseTracker == 1 && npc.playerDialogue.Length >= 1)
            {
                playerResponse.text = npc.playerDialogue[1];
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    npcDialogueBox.text = npc.dialogue[2];
                }
            }
            else if (curResponseTracker == 1 && npc.playerDialogue.Length >= 2)
            {
                playerResponse.text = npc.playerDialogue[2];
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    npcDialogueBox.text = npc.dialogue[3];
                }
            }


        } 
    }

        void StartConversation()
        {
            isTalking = true;
            curResponseTracker = 0;
            dialogueUI.SetActive(true);
            npcName.text = npc.name;
            npcDialogueBox.text = npc.dialogue[0];

        }
   

   void EndDialogue()
    {
        isTalking = false;
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        OnSpeak();
    }
}
