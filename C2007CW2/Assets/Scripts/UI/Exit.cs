using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Button ThisButton;
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
        Invoke("ExitGame", 0.3f);
        
    }

    void ExitGame()
    {
        Application.Quit();

    }
}
