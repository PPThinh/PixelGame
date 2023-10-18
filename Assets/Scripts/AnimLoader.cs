using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimLoader : MonoBehaviour
{
    public Animator animator;
    public float duration = 1f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2))
            LoadNextLevel();
        if(Input.GetKeyDown(KeyCode.F3))
            LoadPreLevel();

    }

    IEnumerator LoadLevel(int index)
    {
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(duration);
        SceneManager.LoadScene(index);
    }

    private void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex+1));
    }
    private void LoadPreLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
    }
}
