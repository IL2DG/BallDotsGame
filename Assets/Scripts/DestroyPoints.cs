using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPoints : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player"){
            Destroy(gameObject);
        }
    }
}
