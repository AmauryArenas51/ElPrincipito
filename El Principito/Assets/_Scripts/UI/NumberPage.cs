using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class NumberPage : MonoBehaviour
{

    private TextMeshProUGUI page;

    public string set;

    // Start is called before the first frame update
    void Start()
    {
        page = this.GetComponent<TextMeshProUGUI>();

        set = SceneManager.GetActiveScene().buildIndex.ToString("0");

        page.text = set.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
