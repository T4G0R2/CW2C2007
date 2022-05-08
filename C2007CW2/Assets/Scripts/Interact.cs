using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    private GameObject Player;
    private TextHandler TH;
    private EnemyController Enemy;
    private Endinghandler EH;
    private DeathHandler DH;
    public GameObject KeysObj;
    public GameObject TZ4;
    public GameObject TZ5;

    public void OnInteract()
    {
        if (this.gameObject.name == "HomeDoor")
        {
            Player = GameObject.FindWithTag("Player");
            TH = Player.GetComponent<TextHandler>();
            EH = Player.GetComponent<Endinghandler>();
            if (TH.HasKeys == false)
            {
                TH.HomeDoorFalse();
                KeysObj.SetActive(true);
                Enemy = Player.GetComponent<EnemyController>();
                Enemy.Despawn();
                EH.TouchedDoor1 = true;
            }
            if (TH.HasKeys == true)
            {
                TH.HomeDoorTrue();
                EH.TouchedDoor2 = true;
                Enemy.SpawnEnemyT4();
            }
        }

        if (this.gameObject.name == "EvilDoor")
        {
            Player = GameObject.FindWithTag("Player");
            TH = Player.GetComponent<TextHandler>();
            EH = Player.GetComponent<Endinghandler>();
            TH.DeathDoor();
            EH.DeathDoor = true;
            DH = Player.GetComponent<DeathHandler>();
            DH.Death();
        }

        if (this.gameObject.name == "Keys")
        {
            Player = GameObject.FindWithTag("Player");
            TH = Player.GetComponent<TextHandler>();
            EH = Player.GetComponent<Endinghandler>();
            TH.Keys();
            TH.HasKeys = true;
            Destroy(this.gameObject);
            TZ4.SetActive(true);
            TZ5.SetActive(true);
            EH.PickedUpKeys = true;
        }
    }

}
