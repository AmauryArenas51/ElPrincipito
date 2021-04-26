using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOpacity : MonoBehaviour
{

    public Animator boaAbierta, boaCerrada;

    // Start is called before the first frame update
    void Start()
    {
        boaAbierta = GameObject.FindGameObjectWithTag("Animation1").GetComponent<Animator>();
        boaCerrada = GameObject.FindGameObjectWithTag("Animation2").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BoaCerrada()
    {
        ButtonFirsttoFinal(boaCerrada, boaAbierta, "BC-BA");
    }
    
    public void BoaAbierta()
    {
        ButtonFirsttoFinal(boaAbierta, boaCerrada, "BA-BC");
    }
    
    public void ButtonFirsttoFinal(Animator animator1, Animator animator2, string trigger)
    {
        animator1.SetTrigger(trigger);
        animator2.SetTrigger(trigger);
        
    }
    
}
