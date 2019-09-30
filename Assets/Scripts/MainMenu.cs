using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {

    //Organ Model Scene
    public void Organs()
    {
        SceneManager.LoadScene("OrganModels");
    }

    //Room Scene
    public void Room()
    {
        SceneManager.LoadScene("room");
    }

    //Test Scene
    public void Test()
    {
        SceneManager.LoadScene("testscene");
    }

    //3D Scene
    public void ThreeD()
    {
        SceneManager.LoadScene("threedee");
    }

    //Main Menu Scene
    //public void Main()
    //{
    //    SceneManager.LoadScene("main_menu");
    //}

}
