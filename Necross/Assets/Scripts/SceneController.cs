using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused = false;

    public int savedNum;

    public float time;

    public void ChangeScene(int sceneNum)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneNum);
    }

    public void ChangeSceneTimed(int sceneNum)
    {
        savedNum = sceneNum;
        StartCoroutine(Change());
    }

    IEnumerator Change()
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(savedNum);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused == false)
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
                isPaused = true;
            }
            else if (isPaused == true)
            {
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
                isPaused = false;
            }
        }
    }
}
