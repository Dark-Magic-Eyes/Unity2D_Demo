using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyField : MonoBehaviour
{
    public bool IsPlusPoint = false;
    private void OnTriggerEnter2D(Collider2D other) {
        if(IsPlusPoint)
        {
            GameManager.Instance.AddPoint();
        }
        Destroy(other.gameObject);
    }
}
