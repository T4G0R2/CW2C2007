using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathHandler : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;
    private AudioSource DeathSound;
    private AudioListener AL;
    private Endinghandler EH;
    public GameObject End1;
    public GameObject End2;
    public GameObject End3;
    public GameObject End4;
    public GameObject End5;
    public GameObject EndScreen;
    public Transform canvas;
    public bool IsDead = false;

    public void Death()
    {
        EH = Player.GetComponent<Endinghandler>();
        if(EH.DeathDoor == true)
        {
            EndScreen = Instantiate(End5);
            EndScreen.transform.parent = canvas;
            Player.SetActive(false);
            DeathSound = Enemy.GetComponent<AudioSource>();
            AL = Enemy.GetComponent<AudioListener>();
            AL.enabled = true;
            DeathSound.Play();
            IsDead = true;
            Invoke("ChangeScene", 10f);
        }
        else if(EH.TouchedDoor1 == false && EH.DeathDoor == false)
        {
            EndScreen = Instantiate(End1);
            EndScreen.transform.parent = canvas;
            Player.SetActive(false);
            DeathSound = Enemy.GetComponent<AudioSource>();
            AL = Enemy.GetComponent<AudioListener>();
            AL.enabled = true;
            DeathSound.Play();
            IsDead = true;
            Invoke("ChangeScene", 10f);
        }
        else if (EH.PickedUpKeys == false && EH.DeathDoor == false)
        {
            EndScreen = Instantiate(End2);
            EndScreen.transform.parent = canvas;
            Player.SetActive(false);
            DeathSound = Enemy.GetComponent<AudioSource>();
            AL = Enemy.GetComponent<AudioListener>();
            AL.enabled = true;
            DeathSound.Play();
            IsDead = true;
            Invoke("ChangeScene", 10f);
        }
        else if (EH.TouchedDoor2 == false && EH.DeathDoor == false)
        {
            EndScreen = Instantiate(End3);
            EndScreen.transform.parent = canvas;
            Player.SetActive(false);
            DeathSound = Enemy.GetComponent<AudioSource>();
            AL = Enemy.GetComponent<AudioListener>();
            AL.enabled = true;
            DeathSound.Play();
            IsDead = true;
            Invoke("ChangeScene", 10f);
        }
        else if (EH.TouchedDoor2 == true && EH.DeathDoor == false)
        {
            EndScreen = Instantiate(End4);
            EndScreen.transform.parent = canvas;
            Player.SetActive(false);
            DeathSound = Enemy.GetComponent<AudioSource>();
            AL = Enemy.GetComponent<AudioListener>();
            AL.enabled = true;
            DeathSound.Play();
            IsDead = true;
            Invoke("ChangeScene", 10f);
        }
    }

    void ChangeScene()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(0);
    }
}
