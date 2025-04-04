using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetItems : MonoBehaviour
{
    private Vector3 spawnPos;
    void Start()
    {
        spawnPos = transform.position;
    }

    public void Spawn()
    {
        transform.position = spawnPos;
        transform.rotation = Quaternion.identity;
    }
}
