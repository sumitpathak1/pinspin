using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    public bool gameHasEnded = false;
    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;

    public void EndGame()
    {
        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");
        gameHasEnded = true;
        

    }

    public void RestartLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
