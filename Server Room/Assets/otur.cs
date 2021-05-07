using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otur : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
        /* anim = gameObject.GetComponent<Animator>();
         anim.runtimeAnimatorController = Resources.Load("Assets/player_controller.controller") as RuntimeAnimatorController;    Animator Controller değiştirme*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
  
    public bool acikMi = false;
    
    public Transform animationPos;
    
    public Animator anim;
    public Transform player;
    public bool icerdeMi = false;

    /*public void icerdeyiz()
    {
    OyuncuMove other;
    GameObject aObject;
        aObject = GameObject.Find("icerdeMi");
        other = aObject.GetComponent<OyuncuMove>();
        other.icerdeMi = true;
    }*/
    public void OnTriggerEnter(Collider other)
    {
        //icerdeyiz();
        if (other.tag == "Player")
        {
            icerdeMi = true;
            



        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            icerdeMi = false;




        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (icerdeMi)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                acikMi = !acikMi;
                player.position = animationPos.position;
                player.rotation = animationPos.rotation;

                if (acikMi == true)
                {
                    anim.SetFloat("Typing", 1);
                }
                
                
            }
            if(Input.GetKeyUp(KeyCode.E))
            {
                if (acikMi == false)
                {
                    anim.SetFloat("Typing", 0);
                }
            }
        }
    }
}
