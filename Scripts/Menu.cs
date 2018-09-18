using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void LoadGame(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
}
