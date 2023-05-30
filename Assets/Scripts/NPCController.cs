using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class NPCInfo
{
    public string NPCName;
}

public class NPCController : MonoBehaviour, IInteractable
{
    public DialogueData dialogueData;

    public GameObject inputPrompt;
    public GameObject dialogueBox;
    public GameObject vCamera;

    public UnityEvent OnInteract;

    public void Interact()
    {
        OnInteract.Invoke();
        Debug.Log("Interacting with: " + gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            inputPrompt.SetActive(true);
            collision.gameObject.GetComponent<PlayerController>().SetCurrentInteractable(this);
            //CamerasController.Instance.SetCameraTarget(transform);
            vCamera.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inputPrompt.SetActive(false);
            collision.gameObject.GetComponent<PlayerController>().SetCurrentInteractable(null);
            //CamerasController.Instance.SetCameraTarget(collision.gameObject.transform);
            vCamera.SetActive(false);
        }
    }
}
