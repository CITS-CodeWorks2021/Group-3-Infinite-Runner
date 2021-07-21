using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactReact : MonoBehaviour
{
    public bool shouldShake;
    public float simpleAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            if (!shouldShake) return;

                CameraShake.onSimpleShake.Invoke(simpleAmount);
        }
    }

}
