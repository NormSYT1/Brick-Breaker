using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play_Game : MonoBehaviour
{
    public void Start_Game()
    {
        SceneManager.LoadScene("Level1");//"Level1" isimli sahneye geç
    }
    public void Main_Scene()
    {
        SceneManager.LoadScene("MainMenu");//"MainMenu" isimli sahneye geç
    }
    public void Quit_Game()
    {
        Application.Quit();//Oyundan çýk
    }
}
