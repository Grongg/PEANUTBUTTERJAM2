using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("MainGame", LoadSceneMode.Single);
    }
}
