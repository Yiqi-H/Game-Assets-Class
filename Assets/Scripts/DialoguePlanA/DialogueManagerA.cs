using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.IO.Pipes;
using UnityEngine.UI;
using TMPro;

public class DialogueManagerA : MonoBehaviour
{
    public NPC npc;

    bool isTalking = false;

    float distance;

    public float curResponseTracker = 0;

    public GameObject player;

    public GameObject dialogueUI;

    public TMP_Text npcName;

    public TMP_Text npcDialogueBox;

    public TMP_Text playerResponse;
    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    // Update is called once per frame
    void OnMouseOver()
    {
        distance = Vector3.Distance(player.transform.position,this.transform.position);
        if(distance <= 2.5f)
        {
            if(Input.GetAxis("Mouse ScrollWheel") < 0f)
            {
                Debug.Log("!!!");
                curResponseTracker++;
                if(curResponseTracker >= npc.playerDialogue.Length -1 )
                {
                    Debug.Log("1");
                    curResponseTracker = npc.playerDialogue.Length - 1;
                }
            }
            else if(Input.GetAxis("Mouse ScrollWheel") > 0f)
            {
                Debug.Log("!!!11");
                curResponseTracker--;
                if(curResponseTracker <0)
                {
                    curResponseTracker = 0;
                }
            }
            //trigger dialogue
            if(Input.GetKeyDown(KeyCode.E) && isTalking == false )
            {
                StartConversation();
            }
            else if(Input.GetKeyDown(KeyCode.E) && isTalking == true)
            {
                EndDialogue();
            }

            if(curResponseTracker == 0 && npc.playerDialogue.Length >= 0)
            {
                playerResponse.text = npc.playerDialogue[0];
                if(Input.GetKeyDown(KeyCode.F))
                {
                    npcDialogueBox.text = npc.dialogue[1];
                }

                else if(curResponseTracker == 1 && npc.playerDialogue.Length >= 1)
                {
                    playerResponse.text = npc.playerDialogue[1];
                    if(Input.GetKeyDown(KeyCode.F))
                    {
                        npcDialogueBox.text = npc.dialogue[2];
                    }
                }
                else if(curResponseTracker == 2 && npc.playerDialogue.Length >= 2)
                {
                    playerResponse.text = npc.playerDialogue[2];
                    if(Input.GetKeyDown(KeyCode.F))
                    {
                        npcDialogueBox.text = npc.dialogue[3];
                    }
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
    
}
