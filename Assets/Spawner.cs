using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawn Prefab")]
    [SerializeField] private GameObject leftSpawnPf;
    [SerializeField] private GameObject downSpawnPf;
    [SerializeField] private GameObject upSpawnPf;
    [SerializeField] private GameObject rightSpawnPf;

    [Header("Spawn Points")]
    [SerializeField] private Transform leftSpawnPoint;
    [SerializeField] private Transform downSpawnPoint;
    [SerializeField] private Transform upSpawnPoint;
    [SerializeField] private Transform rightSpawnPoint;

    [Header("Spawner Data")]
    [SerializeField] private float delay;
    private float timer;
    private int randomIndex;

    private void SpawnLeft()
    {
        Instantiate(leftSpawnPf, leftSpawnPoint.position, Quaternion.identity);
    }

    private void SpawnDown()
    {
        Instantiate(downSpawnPf, downSpawnPoint.position, Quaternion.identity);
    }

    private void SpawnUp()
    {
        Instantiate(upSpawnPf, upSpawnPoint.position, Quaternion.identity);
    }

    private void SpawnRight()
    {
        Instantiate(rightSpawnPf, rightSpawnPoint.position, Quaternion.identity);
    }

    private void Start()
    {
        timer = 0;
        randomIndex = Random.Range(1, 4);
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delay)
        {
            switch(randomIndex)
            {
                case 1:
                    SpawnLeft();
                    break;

                case 2:
                    SpawnDown();
                    break;

                case 3:
                    SpawnUp();
                    break;

                case 4:
                    SpawnRight();
                    break;
            }

            randomIndex = Random.Range(1, 4);
            timer = 0;
        }
    }
}
