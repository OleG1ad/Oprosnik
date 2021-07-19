using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gender;
    public GameObject signIn;
    public GameObject signUp;
    public GameObject ageRange;
    public GameObject emailGO;


    public void Start()
    {
        gender.gameObject.SetActive(true);
        signIn.gameObject.SetActive(false);
        signUp.gameObject.SetActive(false);        
        ageRange.gameObject.SetActive(false);
        emailGO.gameObject.SetActive(false);
    }


    public void SignInCanvas()
    {
        signIn.gameObject.SetActive(true);
        signUp.gameObject.SetActive(false);
        gender.gameObject.SetActive(false);
        ageRange.gameObject.SetActive(false);
        emailGO.gameObject.SetActive(false);
    }

    public void SignUpCanvas()
    {
        signIn.gameObject.SetActive(false);
        signUp.gameObject.SetActive(true);        
        gender.gameObject.SetActive(false);
        ageRange.gameObject.SetActive(false);
        emailGO.gameObject.SetActive(false);
    }

    public void AgeRangeCanvas()
    {
        signIn.gameObject.SetActive(false);
        signUp.gameObject.SetActive(false);
        gender.gameObject.SetActive(false);
        ageRange.gameObject.SetActive(true);
        emailGO.gameObject.SetActive(false);
    }

    public void EmailGOCanvas()
    {
        signIn.gameObject.SetActive(false);
        signUp.gameObject.SetActive(false);
        gender.gameObject.SetActive(false);
        ageRange.gameObject.SetActive(false);
        emailGO.gameObject.SetActive(true);
    }    
}
