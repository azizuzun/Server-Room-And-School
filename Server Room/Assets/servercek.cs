using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class servercek : MonoBehaviour
{
    private Animator _animator;
    public bool acikMi = false;
    public bool icerdeMi = false;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (icerdeMi)
        {


            if (Input.GetKeyDown(KeyCode.V))
            {

                /*Açık Değilse Açıyor*/
                acikMi = !acikMi;
                _animator.SetBool("svcek", acikMi);
            }
        }
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
}
