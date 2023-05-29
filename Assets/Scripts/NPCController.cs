using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour, IInteractable
{
    public GameObject inputPrompt;
    public GameObject dialogueBox;
    public GameObject vCamera;

    public void Interact()
    {
        throw new System.NotImplementedException();

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
