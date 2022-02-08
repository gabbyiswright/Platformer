using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("dead?111");

        var player = collision.gameObject.GetComponent<PhysKiller>();
        if (player == null) return;

        Debug.Log("dead?");

        player.Kill();
    }
}
