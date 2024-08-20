using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botão : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("Cenário");
    }
}
