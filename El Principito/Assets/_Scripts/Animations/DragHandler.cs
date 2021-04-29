using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DragHandler : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public float moveForce;

    public bool drop;

    private CanvasGroup _canvasGroup;
    
    public AudioClip clip;

    public AudioSource _audioSource;
    
    //public Imag


    void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Parent"))
        {
            drop = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Parent"))
        {
            drop = false;
        }
    }
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        _canvasGroup.blocksRaycasts = false;
        _audioSource.PlayOneShot(clip, 1);

    }
    
    
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    

    public void OnEndDrag(PointerEventData eventData)
    {

        if (drop == false)
        {
            //Encontar el Rigidbody del Item
            Rigidbody2D itemRigidbody = this.gameObject.GetComponent<Rigidbody2D>();
        
            //Calcular el vector de la resta de la posición del mouse menos la posición del Item
            Vector2 awayFromMouse = Input.mousePosition - transform.position;
        
            //Añadir la fuerza de impulso al Rigidbody del Item
            itemRigidbody.AddForce(awayFromMouse * moveForce, ForceMode2D.Impulse);
        }
        
        _canvasGroup.blocksRaycasts = true;

    }


}
