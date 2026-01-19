using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Control : MonoBehaviour
{
    public static bool game_paused = false;//Oyunun durup durmadýðýný kontrol eden deðiþken
    public GameObject pause_menu;//Oyun nesnesi
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))//Esc tuþuna basýlýrsa
        {
            AudioListener.volume = 0;//Sesleri sustur
            if (game_paused) 
            {
                Resume();//Oyuna devam et fonksiyonunu çaðýr
            }
            else
            {
                Pause();//Oyunu durdur fonksiyonunu çaðýr
            }
        }
    }
    public void Resume()
    {
        AudioListener.volume = 1;//Sesleri çal
        pause_menu.SetActive(false);//Butonu görünmez yap
        Time.timeScale = 1f;//Oyunu devam ettir
        game_paused = false;//Oyun durdu deðiþkeni "false" olsun
    }
    public void Pause()
    {
        pause_menu.SetActive(true);//Butonu aktif et
        Time.timeScale = 0f;//Oyunu durdur
        game_paused = true;//Oyun durdu deðiþkeni "true" olsun
    }
    public void Load_Menu()
    {
        AudioListener.volume = 1;//Sesleri çal
        Time.timeScale = 1f;//Oyunu durdur
        SceneManager.LoadScene("MainMenu");//Ana menüyü yükler
    }
    public void Next_Scene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Bir sonraki sahneyi yükler
    }
    public void Current_Scene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//Mevcut sahneyi yükler
    }
}
