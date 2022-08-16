using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    public GameObject gameCont;
    public GameObject lose;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player"){
            Destroy(other.gameObject);
            Destroy(gameCont);
            lose.SetActive(true);
        }
    }
}
