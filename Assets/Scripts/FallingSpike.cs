using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpike : MonoBehaviour
{
    public GameObject spikeBody;
    private Rigidbody2D spikeRigid;

    private void Start()
    {
        spikeRigid = spikeBody.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.gameObject.GetComponent<PlayerController>();
        if (player == null) return;

        spikeRigid.gravityScale = 2;
    }
}
