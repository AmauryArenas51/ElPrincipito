using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneLoader : MonoBehaviour
{
    
    public float transitionTime = .5f;

    private ChooseNOP NoP;

    private protected Animator nextAnimation;
    
    private protected Animator previusAnimation;

    
    private void Start()
    {
        SetAll();

        nextAnimation = GameObject.FindGameObjectWithTag("NextAnimation").GetComponent<Animator>();
                
        previusAnimation = GameObject.FindGameObjectWithTag("PreviusAnimation").GetComponent<Animator>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && NoP.next)
        {
            LoadNextScene();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && NoP.previus)
        {
            LoadPreviusScene();

        }
    }

    // ReSharper disable Unity.PerformanceAnalysis
    private void SetAll()
    {
        NoP = GameObject.FindGameObjectWithTag("NoP").GetComponent<ChooseNOP>();

        GameObject[] next = GameObject.FindGameObjectsWithTag("Next");

        GameObject[] previus = GameObject.FindGameObjectsWithTag("Previus");

        Buttons(NoP.next, next);

        Buttons(NoP.previus, previus);
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1, nextAnimation));
    }
    
    public void LoadPreviusScene()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex - 1, previusAnimation));
    }

    protected IEnumerator LoadScene(int levelIndex, Animator animator)
    {

        //Play animation
        animator.SetTrigger("Start");
        
        //Wait
        yield return new WaitForSeconds(transitionTime);

        //Load scene
        SceneManager.LoadScene(levelIndex);

    }

    
    void Buttons(bool CNoP, GameObject[] NoP)
    {
        if (CNoP == true)
        {
            for(int i = 0; i < NoP.Length; i++)
            {
                NoP[i].SetActive(true);
            }
        }
        else if (CNoP == false)
        {
            for(int i = 0; i < NoP.Length; i++)
            {
                NoP[i].SetActive(false);
            }
        }
        {
            
        }
    }
    
}
