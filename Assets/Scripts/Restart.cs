using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartLevel(){
        SceneManager.LoadScene(0);
    }
}
