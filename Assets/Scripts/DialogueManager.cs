using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class DialogueInfo
{
    public string dialogueID;
    public string dialogueText;
    public Sprite dialogueSprite;
    public AudioClip dialogueAudioClip;
    public UnityEvent onDialogueComplete;
}

[CreateAssetMenu(fileName = "DialogueData", menuName = "Custom/DialogueData", order = 0)]
public class DialogueData : ScriptableObject
{
    public List<DialogueInfo> dialogueInfos = new List<DialogueInfo>();
}

public class DialogueManager : MonoBehaviour
{
    public DialogueData currentDialogueData;
    public void SetupDialogue(DialogueData _data)
    {
        currentDialogueData = _data;
    }
}
