using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assigment2Array : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int counter=1;
        string funnySentence = "";
        string[] someWords={ "Cat", "Dog" , "Car" , "Pizza" , "Hat" , "Fish" , "Tree" , "Monkey" , "Ball" , "Bird" };
        while(counter<=7)
        {
            int randomNumber= Random.Range(1,8);
            Debug.Log(someWords[randomNumber]);
            funnySentence += someWords[randomNumber] + " " ;
            counter++;
        }

        Debug.Log("The funny sentence is:" + " " + funnySentence);


    }
}
