using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class TextManager : MonoBehaviour
{
    [SerializeField] private string currentCrewMessage;
    [SerializeField] TextMeshProUGUI currentCrewTextBox;

    [SerializeField] private string currentApplicantMessage;
    [SerializeField] TextMeshProUGUI currentApplicantTextBox;

    //public GameObject mostRecentApplicant;
    //Instead of trying to access the most recent instantiation, let's access the variable that's already 'onboard' the ship.
    [SerializeField] private Ship shipAccess;
    //mostRecentApplicant = GameObject.Find("(Clone)");
    //currentApplicantMessage


    //shipAcess is the 'name' used to ACCESS that class I want. mostRecentApplicant is already a variable in the class. I can further access whatever variable that variable has access to.
    //shipAccess.mostRecentApplicant.THEVARIABLE




    public void UpdateCurrentApplicant()
    {
        // \n is a linebreak
        // \t is an indent
        // Use +=

        // FORMAT: APPLICANT NAME: + [name] + \n APPLICANT HOBBY: + [hobby];
        //currentApplicantTextBox.text = "";

        //Finding out what order things are happening in. THIS debug.log happens before the crew debug log, which means name and hobby are still empty when these variables are pulled. I need to change it to after.
        //Debug.Log("TEXT " + shipAccess.mostRecentApplicant.name);
        currentApplicantTextBox.text = "";
        Debug.Log("Cleared Current Applicant");
        currentApplicantTextBox.text += "APPLICANT NAME: " + shipAccess.mostRecentApplicant.name +  "\nAPPLICANT HOBBY: " + shipAccess.mostRecentApplicant.hobby;
        Debug.Log("Printed most recent Applicant");
    }

    public void UpdateCurrentCrew()
    {
        // \n is a linebreak
        // \t is an indent
        // Use +=

        //                           Place holder - needs to be the cloned gameobject's variable
        currentCrewTextBox.text += "\n" + shipAccess.mostRecentApplicant.name + " // " + shipAccess.mostRecentApplicant.hobby;
    }

}
