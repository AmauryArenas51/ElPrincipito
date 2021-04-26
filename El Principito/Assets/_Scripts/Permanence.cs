using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Permanence : MonoBehaviour
{
    public static Permanence inst;
    
    // Start is called before the first frame update
    void Awake()
    {
        if (Permanence.inst == null)
        {
            Permanence.inst = this;
        }
        else
        {
            Destroy(gameObject);
        }
            
        GameObject.DontDestroyOnLoad(this.gameObject);
        
    }

}
