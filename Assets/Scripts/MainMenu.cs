using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void Organs()
    {
        SceneManager.LoadScene("OrganModels");
    }

    public void Main()
    {
        SceneManager.LoadScene("main_menu");
    }
}