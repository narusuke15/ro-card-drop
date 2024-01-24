using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Button))]
public class CustomButton : MonoBehaviour
{
    public static ISoundManager SoundManager;
    public AudioClip ClickSound;
    protected Button button;
    protected bool interactable = false;
    protected AudioSource audioSource;

    protected virtual void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(delegate { ClickHandler(); });
    }

    protected virtual void Start()
    {
        if (ClickSound != null)
            audioSource = gameObject.AddComponent<AudioSource>();

        if (Time.timeScale > 0)
            StartCoroutine(DelayButton());
        else
            interactable = true;

        if (SoundManager == null)
            Debug.LogWarning("CustomButton : SoundManager Not Assigned.");
    }

    protected IEnumerator DelayButton()
    {
        interactable = false;
        yield return new WaitForSeconds(0.2f);
        interactable = true;
    }

    protected virtual void ClickHandler()
    {
        //หดได้ตอลดถ้า time scale = 0
        if (!interactable && Time.timeScale > 0)
            return;
        if (ClickSound != null)
            SoundManager.PlaySound(ClickSound);

        OnClick();
    }

    protected virtual void OnClick()
    {

    }

}