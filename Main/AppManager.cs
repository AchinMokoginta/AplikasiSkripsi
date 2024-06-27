using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppManager : MonoBehaviour
{
    public void PakaianAdatLaki()
    {
        SceneManager.LoadScene("PakaianAdatLaki");
    }

    public void PakaianAdatPerempuan()
    {
        SceneManager.LoadScene("PakaianAdatPerempuan");
    }

    public void MenuUtama()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void KeluarAplikasi()
    {
        Application.Quit();
    }
}
