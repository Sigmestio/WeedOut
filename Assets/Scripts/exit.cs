using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    
    public GameObject youescapedPlane;
    public GameObject youescapedText;
    public GameObject exitText;
    public AudioSource congrats;


    [SerializeField] private bool inReach;


    void Start()
    {
        inReach = false;
        youescapedPlane.SetActive(false);
        youescapedText.SetActive(false);


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            exitText.SetActive(true);


        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            exitText.SetActive(false);

        }
    }


    void Update()
    {
        if (inReach && Input.GetButtonDown("Interact"))
        {
            youescapedPlane.SetActive(true);
            youescapedText.SetActive(true);
            congrats.Play();



        }


    }
}
