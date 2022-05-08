using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvents : MonoBehaviour
{
    private TextHandler TH;
    private GameObject Player;
    private EnemyController Enemy;
    private DeathHandler DH;
    public GameObject NextTZ;
    public AudioSource BoomSound;
    public GameObject CurrentObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && this.gameObject.name == "TZ1")
        {
            BoomSound = CurrentObj.GetComponent<AudioSource>();
            Player = other.gameObject;
            TH = Player.GetComponent<TextHandler>();
            TH.TZ1();
            BoomSound.Play();
            Destroy(this.gameObject, 0.8f);
            NextTZ.SetActive(true);
        }

        if (other.CompareTag("Player") && this.gameObject.name == "TZ2")
        {
            BoomSound = CurrentObj.GetComponent<AudioSource>();
            Player = other.gameObject;
            TH = Player.GetComponent<TextHandler>();
            TH.TZ2();
            BoomSound.Play();
            Destroy(this.gameObject, 0.8f);
            NextTZ.SetActive(true);
        }

        if (other.CompareTag("Player") && this.gameObject.name == "TZ3")
        {
            BoomSound = CurrentObj.GetComponent<AudioSource>();
            Player = other.gameObject;
            TH = Player.GetComponent<TextHandler>();
            Enemy = Player.GetComponent<EnemyController>();
            Enemy.SpawnEnemyT1();
            TH.TZ3();
            BoomSound.Play();
            Destroy(this.gameObject, 0.8f);
        }

        if (other.CompareTag("Player") && this.gameObject.name == "TZ4")
        {
            BoomSound = CurrentObj.GetComponent<AudioSource>();
            Player = other.gameObject;
            TH = Player.GetComponent<TextHandler>();
            Enemy = Player.GetComponent<EnemyController>();
            Enemy.SpawnEnemyT3();
            TH.TZ4();
            BoomSound.Play();
            Destroy(this.gameObject, 0.8f);
        }

        if (other.CompareTag("Player") && this.gameObject.name == "TZ5")
        {
            BoomSound = CurrentObj.GetComponent<AudioSource>();
            Player = other.gameObject;
            TH = Player.GetComponent<TextHandler>();
            Enemy = Player.GetComponent<EnemyController>();
            Enemy.SpawnEnemyT2();
            TH.TZ5();
            BoomSound.Play();
            Destroy(this.gameObject, 0.8f);
        }

        if (other.CompareTag("Player") && CurrentObj.CompareTag("Enemy"))
        {
            Player = other.gameObject;
            DH = Player.GetComponent<DeathHandler>();
            DH.Death();
        }
    }
}
