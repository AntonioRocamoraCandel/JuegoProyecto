using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeweakersController : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            HealthController.Instance.Hurt(1);
        }
    }
}