using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class serverparcala : MonoBehaviour
{
    public GameObject ramyazi;
    public GameObject islemciyazi;
    public GameObject fanyazi;
    public GameObject harddiskyazi;
    public GameObject kapatserver;
    public bool ramacik = false;
    public bool islemciacik = false;
    public bool hddacik = false;
    public bool fanacik = false;

    private Animator _animator;
    public bool acikMi = false;
    public bool icerdeMi = false;
    public GUILayout winText;

    private bool render = false;
    private Rect windowRect = new Rect(20, 20, 120, 50);

    // Start is called before the first frame update
    void Start()
    {
        ramyazi.SetActive(false);
        islemciyazi.SetActive(false);
        fanyazi.SetActive(false);
        harddiskyazi.SetActive(false);
        kapatserver.SetActive(false);
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
                /*if (this._animator.GetCurrentAnimatorStateInfo(0).IsName("serverparcala"))
                {
                    ramyazi.SetActive(true);
                    islemciyazi.SetActive(true);
                    fanyazi.SetActive(true);
                    harddiskyazi.SetActive(true);
                }*/
                
                
                _animator.SetBool("parcala", acikMi);
                _animator.SetBool("parcalar", !acikMi);
                _animator.SetBool("parcalai", !acikMi);
                _animator.SetBool("parcalaf", !acikMi);
                _animator.SetBool("parcalah", !acikMi);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                ramacik = true;
                hddacik = false;
                islemciacik = false;
                fanacik = false;
                _animator.SetBool("parcala", !acikMi);
                _animator.SetBool("parcalaf", !acikMi);
                _animator.SetBool("parcalah", !acikMi);
                _animator.SetBool("parcalai", !acikMi);
                _animator.SetBool("parcalar", acikMi);
                
                



            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                ramacik = false;
                hddacik = false;
                islemciacik = true;
                fanacik = false;
                _animator.SetBool("parcala", !acikMi);
                _animator.SetBool("parcalar", !acikMi);
                _animator.SetBool("parcalaf", !acikMi);
                _animator.SetBool("parcalah", !acikMi);
                _animator.SetBool("parcalai", acikMi);
                
                

            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                ramacik = false;
                hddacik = false;
                islemciacik = false;
                fanacik = true;
                _animator.SetBool("parcala", !acikMi);
                _animator.SetBool("parcalar", !acikMi);
                _animator.SetBool("parcalah", !acikMi);
                _animator.SetBool("parcalai", !acikMi);
                _animator.SetBool("parcalaf", acikMi);

            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                ramacik = false;
                hddacik = true;
                islemciacik = false;
                fanacik = false;
                _animator.SetBool("parcala", !acikMi);
                _animator.SetBool("parcalar", !acikMi);
                _animator.SetBool("parcalaf", !acikMi);
                _animator.SetBool("parcalai", !acikMi);
                _animator.SetBool("parcalah", acikMi);

            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                _animator.SetBool("parcala", !acikMi);
                _animator.SetBool("parcalar", !acikMi);
                _animator.SetBool("parcalaf", !acikMi);
                _animator.SetBool("parcalai", !acikMi);
                _animator.SetBool("parcalah", !acikMi);
                acikMi = false;
                

            }



        }
        if(acikMi==true)
        {
            ramyazi.SetActive(true);
            islemciyazi.SetActive(true);
            fanyazi.SetActive(true);
            harddiskyazi.SetActive(true);
            kapatserver.SetActive(true);
        }
        if (acikMi == false)
        {

            ramyazi.SetActive(false);
            islemciyazi.SetActive(false);
            fanyazi.SetActive(false);
            harddiskyazi.SetActive(false);
            kapatserver.SetActive(false);
        }
        

    }
    void OnGUI()
    {
        if(acikMi==true)
        {

            string r = "32 Adet DDR4 DIMM slotu bulunmakta ve \n hızları 2,666 MT/s'ye kadar çıkabilmektedir.";
           
            string i = "2 or 4 Intel® Xeon® Scalable Processors \n of up to 205W: Platinum 8100, Gold 6100, \n or Gold 5100 series";

            string h = "Sabit diskler aşağıdaki konfigürasyon özelliklerini destekliyor: \n  8 x 2.5 - inch SAS / SATA HDDs on the front 25 x 2.5 - inch \n SAS / SATA HDDs on the front· 8 x 2.5 - inch \n NVMe SSDs and 16 x 2.5 - inch SAS / SATA HDDs on the front \n Flash storage:· 2 x M.2 SSDs \n";


            if (ramacik==true)
            {
                i = "";
                h = "";
                r =GUI.TextField(new Rect(10, 20, 290, 50),r,200);
                
            }
            
            if (islemciacik==true)
            {
                r = "";
                h = "";
                i = GUI.TextField(new Rect(10, 20, 320, 70), i, 240);

            }
            if (hddacik == true)
            {
                r = "";
                i = "";
                h = GUI.TextField(new Rect(10, 20, 420, 90), h, 305);

            }
        }
    }



    }
