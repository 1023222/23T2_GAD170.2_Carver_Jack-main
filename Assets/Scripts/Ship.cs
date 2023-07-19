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
    public GameObject ApplicantPrefab;
    //private Crew crewScript;
    public Crew mostRecentApplicant;
    public TextManager textManagerAccess;

    private string accessedCrewName;

    private void Start()
    {
        //crewScript = ApplicantPrefab.GetComponent<Crew>();
        //string accessedCrewName = crewScript.name;
        //string accessedCrewHobby = crewScript.hobby;
    }



    //This method instantiates a new applicant when the 'next applicant' button is pressed.
    public void InstantiateApplicant()
    {
        //Crew mostRecentApplicant = Instantiate(ApplicantPrefab);
        mostRecentApplicant = Instantiate(ApplicantPrefab).GetComponent<Crew>();
        //GameObject applicant = GameObject.Find("Applicant(Clone)");
        //applicant.name = crewScript.name;
        //crewScript = ApplicantPrefab.GetComponent<Crew>();
        string accessedCrewName = mostRecentApplicant.name;
        string accessedCrewHobby = mostRecentApplicant.hobby;
        mostRecentApplicant.name = accessedCrewName;
        //print("NEW" + mostRecentApplicant.name);
        //textManagerAccess.UpdateCurrentApplicant();
    }

    //This method adds the current applicant to the acceptedApplicants (crew) list and instantiates a new applicant for review.
    public void HireApplicant()
    {
        //GameObject m = GameObject.Find("Applicant(Clone)");
        // finding the instantiated gameobject and adding it to the list/array
        successfulApplicants.Add(mostRecentApplicant.gameObject);
    }

    public void DebugCrewLog()
    {
        Debug.Log(successfulApplicants[0]);
    }

}  
