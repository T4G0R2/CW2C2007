using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHandler : MonoBehaviour
{
    public Text CanvasText;
    public bool HasKeys = false;
    // Start is called before the first frame update
    void Start()
    {
        GameStartTextSpawn();
        Invoke("GameStartTextDestroy", 7f);
    }

    public void TZ1()
    {
        STZ1T();
        Invoke("DTZ1T", 3f);
    }

    void STZ1T()
    {
        CanvasText.text = "What in the hell was that sound?..";
        CanvasText.enabled = true;
    }

    void DTZ1T()
    {
        CanvasText.enabled = false;
    }

    public void TZ2()
    {
        STZ2T();
        Invoke("DTZ2T", 3f);
    }

    void STZ2T()
    {
        CanvasText.text = "I should really hurry, this neighbourhood is dangerous at night...";
        CanvasText.enabled = true;
    }

    void DTZ2T()
    {
        CanvasText.enabled = false;
    }

    public void TZ3()
    {
        STZ3T();
        Invoke("DTZ3T", 3f);
    }

    void STZ3T()
    {
        CanvasText.text = "Run, run, run!";
        CanvasText.enabled = true;
    }

    void DTZ3T()
    {
        CanvasText.enabled = false;
    }

    public void TZ4()
    {
        STZ4T();
        Invoke("DTZ4T", 3f);
    }

    void STZ4T()
    {
        CanvasText.text = "It's back! Quick, Home!";
        CanvasText.enabled = true;
    }

    void DTZ4T()
    {
        CanvasText.enabled = false;
    }

    public void TZ5()
    {
        STZ5T();
        Invoke("DTZ5T", 3f);
    }

    void STZ5T()
    {
        CanvasText.text = "It's comming right after me!";
        CanvasText.enabled = true;
    }

    void DTZ5T()
    {
        CanvasText.enabled = false;
    }

    public void HomeDoorFalse()
    {
        SHDF();
        Invoke("DHDF", 5f);
    }

    void SHDF()
    {
        CanvasText.text = "I can't find my keys! I probably dropped them on the way... Will have to go and look for them.";
        CanvasText.enabled = true;
    }

    void DHDF()
    {
        CanvasText.enabled = false;
    }

    public void HomeDoorTrue()
    {
        SHDT();
        Invoke("DHDT", 5f);
    }

    void SHDT()
    {
        CanvasText.text = "I... Accidentally broke the key... It's over...";
        CanvasText.enabled = true;
    }

    void DHDT()
    {
        CanvasText.enabled = false;
    }

    public void Keys()
    {
        SK();
        Invoke("DK", 5f);
    }

    void SK()
    {
        CanvasText.text = "There they are! I should run home before IT comes back!";
        CanvasText.enabled = true;
    }

    void DK()
    {
        CanvasText.enabled = false;
    }

    public void DeathDoor()
    {
        SDD();
        Invoke("DDD", 5f);
    }

    void SDD()
    {
        CanvasText.text = "Y0u $h0uLdn'T h4v3 T0uCh3D mY d00R";
        CanvasText.enabled = true;
    }

    void DDD()
    {
        CanvasText.enabled = false;
    }

    void GameStartTextSpawn()
    {
        CanvasText.text = "That was sure an awesome party at Tom's. It's late though, I should go home now and get some sleep. My house is the last house on the next street.";
        CanvasText.enabled = true;
    }

    void GameStartTextDestroy()
    {
        CanvasText.enabled = false;

    }
}
