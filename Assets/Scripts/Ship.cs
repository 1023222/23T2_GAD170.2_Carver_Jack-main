using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ship : MonoBehaviour
{
    //Create the list for successfully hired applicants.
    [SerializeField] List<GameObject> successfulApplicants = new List<GameObject>();

    //Instead try an ARRAY because the crew list will always have 10 slots.
    //[SerializeField] public GameObject[] successfulApplicants;
    //Declaring my gameobject to instantiate.
    public GameObject Applicant;


    //This method instantiates a new applicant when the 'next applicant' button is pressed.
    public void InstantiateApplicant()
    {
        Instantiate(Applicant);

    }

    //This method adds the current applicant to the acceptedApplicants (crew) list and instantiates a new applicant for review.
    public void HireApplicant()
    {
        GameObject applicant = GameObject.Find("Applicant(Clone)");
        // acceptedApplicants.Add(applicant);
        //acceptedApplicants.Add(Applicant);
        successfulApplicants.Add(applicant);
    }

    public void DebugCrewLog()
    {
        Debug.Log(successfulApplicants[0]);
    }

}  
