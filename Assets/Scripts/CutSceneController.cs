using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneController : MonoBehaviour
{
    [SerializeField] private Animator animator;


    private void Update()
    {
        EndCutScene();
    }

    IEnumerator EndCutScene()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isPlayed", true);
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }

}
