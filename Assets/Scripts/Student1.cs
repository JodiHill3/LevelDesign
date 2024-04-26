using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Student1 : MonoBehaviour
{
    public void Student_1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   // public void QuitGame()
   // {
   //     Debug.Log("QUIT!");
   //     Application.Quit();
   // }
}
