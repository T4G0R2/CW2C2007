using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject Enemy;
    public Transform EnemyTransform;
    public Transform Player;
    private float MoveSpeed = 20;

    void Update()
    {
        if (Enemy.active == true)
        {
            EnemyTransform.LookAt(Player);
            EnemyTransform.position += transform.forward * -1 * MoveSpeed * Time.deltaTime;
        }
    }

    public void SpawnEnemyT1()
    {
        Enemy.transform.position = new Vector3(-74.66f, 0.74f, -64.7f);
        Enemy.SetActive(true);
    }

    public void SpawnEnemyT2()
    {
        Enemy.transform.position = new Vector3(46.04f, 0.74f, -51.9f);
        Enemy.SetActive(true);
    }

    public void SpawnEnemyT3()
    {
        Enemy.transform.position = new Vector3(-74.66f, 0.74f, -132.7f);
        Enemy.SetActive(true);
    }

    public void SpawnEnemyT4()
    {
        Enemy.transform.position = new Vector3(-83.52f, 0.7399445f, 162.03f);
        Enemy.SetActive(true);
    }

    public void Despawn()
    {
        Enemy.SetActive(false);
    }
}
