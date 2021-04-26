using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexScene : SceneLoader
{

    public int page;

    public void LoadPage()
    {
        StartCoroutine(LoadScene(page, nextAnimation));
    }

}
