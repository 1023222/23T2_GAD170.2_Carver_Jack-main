using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crew : MonoBehaviour
{

    [SerializeField] public string name;
    [SerializeField] private bool isAlien;
    [SerializeField] public string hobby;

    private System.Random rnd = new System.Random();

    // Human Hobbies Array
    private string[] humanHobbies = { "Electronics", "Coding", "Astronomy", "Gaming", "Asteroid Mining", "Star-Mapping" };
    // Alien Hobbies Array
    private string[] alienHobbies = { "Eating skin", "Breathing Oxygen", "Eating real human food" };
    // Names Array
    private string[] names = { "Aeryn", "Mecca", "Dutch", "Lyta", "Ripley", "Talon", "Hal", "Cooper", "Arden", "Victor", "Sura", "Helio", "Elon", "Le Guin", "Samsa" };


    // Start is called before the first frame update
    void Start()
{
        GenerateInfo();
}

    // This will Generate a random value for the variables 'name, isAlien and hobby'
    void GenerateInfo()
    {
        GenerateName();
        GenerateIsAlien();
        if (isAlien == true)
        {
            GenerateAlienHobby();
        }
        else
        {
            GenerateHumanHobby();
        }
        Debug.Log("My name is " + name + " and I'd like to apply for your crew. My specialised hobby is " + hobby + ".");
    }

    void GenerateName()
    {
        name = names[rnd.Next(0, 14)];
    }

    void GenerateIsAlien()
    {
        isAlien = Random.value < 0.10f;
    }

    void GenerateAlienHobby()
    {
        hobby = alienHobbies[rnd.Next(0, 2)];
    }

    void GenerateHumanHobby()
    {
        hobby = humanHobbies[rnd.Next(0, 5)];
    }
}
