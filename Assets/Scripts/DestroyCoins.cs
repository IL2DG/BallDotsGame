using UnityEngine;
using UnityEngine.UI;

public class DestroyCoins : MonoBehaviour
{
    public Text score;
    private int scoreInt = 0;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player"){
            Destroy(gameObject);
            scoreInt =  int.Parse(score.text);
            scoreInt++;
            score.text = scoreInt.ToString();
        }
    }
}
