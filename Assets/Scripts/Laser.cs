using UnityEngine;
using UnityEngine.SceneManagement;

public class Laser : MonoBehaviour
{
    public string sceneToLoad;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Robo")) 
        {
            SceneManager.LoadScene("Cenário"); 
        }
    }
}
