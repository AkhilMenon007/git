using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject shotprefab;
    public Transform shotSpawn;
    public void Shoot()
    {
        Instantiate(shotprefab, shotSpawn.position, shotSpawn.rotation);
    }
}
