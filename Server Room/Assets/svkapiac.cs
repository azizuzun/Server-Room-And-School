using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class svkapiac : MonoBehaviour
{

    private Animator _animator;
    public bool acikMi = false;
    public bool icerdeMi = false;


    // Start is called before the first frame update
    void Start()
    {

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




        }
    }


    // Update is called once per frame
    void Update()
    {

        if (icerdeMi)
        {


            if (Input.GetKeyDown(KeyCode.E))
            {

                /*Açık Değilse Açıyor*/
                acikMi = !acikMi;


                _animator.SetBool("kapiac", acikMi);
            }

        }
    }
}
