using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
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
        Invoke("PlayScene", 0.3f);
        
    }

    void PlayScene()
    {
        SceneManager.LoadScene(1);
    }
}
