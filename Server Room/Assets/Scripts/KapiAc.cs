using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KapiAc : MonoBehaviour
{
    public GameObject OpenPanel = null;
    private Animator _animator;
    public bool acikMi = false;
    public bool icerdeMi = false;

    
    // Start is called before the first frame update
    void Start()
    {
        OpenPanel.SetActive(false);
        _animator = GetComponent<Animator>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            icerdeMi = true;
            
            
            

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            icerdeMi = false;
            OpenPanel.SetActive(false);



        }
    }
    private bool IsOpenPanelActive
    {
        get
        {
            return OpenPanel.activeInHierarchy;
        }
    }
    
    // Update is called once per frame
    void Update()
    {

        if (icerdeMi)
        {
            if (icerdeMi == false)
            {
                OpenPanel.SetActive(false);
            }
            if (icerdeMi == true)
            {
                OpenPanel.SetActive(true);
            }
            if (IsOpenPanelActive)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {

                    /*Açık Değilse Açıyor*/
                    acikMi = !acikMi;


                    _animator.SetBool("open", acikMi);
                }
            }
        }
    }
}
