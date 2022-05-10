using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnGameScript : MonoBehaviour
{
    //  нопка, котора€ выходит из паузы в главное меню
    public void MainMenuBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
