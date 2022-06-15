using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(tankPrefab, transform.position, Quaternion.identity);
        Debug.Log("Tank is Spawned");
    }

    
}
