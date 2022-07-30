using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class justscript : MonoBehaviour
{
    string heroName = "water man";
    float heroHeight = 1.86f;
    int heroAge = 18;
    string heroSuperPower = "water attack";

    string villainName = "fire man";
    float villianHeight = 1.99f;
    int villainAge = 21;
    string villainSuperPower = "fire attack";
    // Start is called before the first frame update
    void Start()
    {
        print("The hero " + heroName + " is " + heroAge + " years old and " + heroHeight + "m tall and his super attack called " + heroSuperPower);
        print("The villain " + villainName + " is " + villainAge + " years old and " + villianHeight + "m tall and his super attack called " + villainSuperPower);
        int ageDiffernce = villainAge - heroAge;
        print("the age differnce between the hero and the villain is " + ageDiffernce + " years");
        heroHeight = heroHeight + 5;
        print("suddenly the hero is now taller and his height is " + heroHeight);
        villainSuperPower = "None";
        print("the villain got scared and his super power now is " + villainSuperPower);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
