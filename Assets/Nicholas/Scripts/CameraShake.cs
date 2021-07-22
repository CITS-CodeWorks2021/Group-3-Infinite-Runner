using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraShake : MonoBehaviour
{
    Vector3 startPos;

    public static UnityEvent<float> onSimpleShake =
        new UnityEvent<float>();

    float simpleAmount;


    void Start()
    {
        startPos = transform.position;

        onSimpleShake.AddListener(HandleOnSimpleShake);

    }

    private void HandleOnSimpleShake(float amount)
    {
        simpleAmount = amount;
    }

    private void Update()
    {
        Vector3 shakePos = startPos;

        if (simpleAmount > 0)
        {
            // Shake it Up
            shakePos.x += Random.Range(-simpleAmount, simpleAmount);
            shakePos.y += Random.Range(-simpleAmount, simpleAmount);

            transform.position = shakePos;
            simpleAmount -= Time.deltaTime;
        }
    }
}
