using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class ButtonHover : MonoBehaviour
{
    public AudioClip AudioClip;
    private AudioSource audioSource;

    //Do this when the cursor enters the rect area of this selectable UI object.
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
            Debug.Log("Works");
        if (audioSource == null)
            audioSource = gameObject.AddComponent<AudioSource>();
            Debug.Log("Works too");

        audioSource.PlayOneShot(AudioClip);
    }
}
