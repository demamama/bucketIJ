using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ruvvish : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out bucket bucket))
        {
            Destroy(gameObject);
        }
    }
}
