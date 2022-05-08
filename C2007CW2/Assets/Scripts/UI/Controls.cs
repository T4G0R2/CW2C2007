using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour
{
    public Button ThisButton;
    public GameObject ThisUI;
    private AudioSource Click;

    void Start()
    {
        Button btn = ThisButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Click = ThisButton.GetComponent<AudioSource>();
        Click.Play();
        ThisUI.SetActive(true);
    }
}
