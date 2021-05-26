using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeRespawner : MonoBehaviour
{
    public Vector3 respawnPoint;
    private void OnTriggerEnter(Collider other) 
    {
        other.transform.position = respawnPoint;
    }
}
