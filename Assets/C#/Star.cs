using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {

        if (!other.TryGetComponent(out Player player)) return;
        player.Stars++;
        Destroy(gameObject);

    }
}
