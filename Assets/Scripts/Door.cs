using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string sceneToLoad; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Robo")) 
        {
            SceneManager.LoadScene("Cenário"); 
        }

         if (other.CompareTag("Robo")) 
        {
            SceneManager.LoadScene("Cenário2"); 
        }
    }
}