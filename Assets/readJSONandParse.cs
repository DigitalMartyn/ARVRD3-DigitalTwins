//This script is a Unity C# script that reads a JSON file and parses it to display information about solar panels in the Unity game engine.
//


//The first four lines are using statements that import the necessary namespaces for the script to function.
//These include System.Collections, System.Collections.Generic, UnityEngine, and TMPro.

//In Unity, a namespace is a way to organize your code and avoid naming conflicts.
//It is a collection of classes that are referred to using a chosen prefix on the class name.
//Namespaces are useful for organizing your code into logical groups and preventing naming conflicts between different pieces of code.
//For example, you might have a namespace for your game's enemy AI code, and another namespace for your game's player character code.
//This helps to keep your code organized and makes it easier to find and understand the different parts of your code.
//You can also use namespaces to avoid naming conflicts with other code, such as third-party libraries or assets that you import into your project.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



//The readJSONandParse class is declared.
//This means that the script can be attached to a GameObject in the Unity scene and will have access to the various Unity lifecycle methods.

public class readJSONandParse : MonoBehaviour
{


    public TextAsset textJSON;  //The textJSON variable is declared as a public TextAsset, which allows you to assign a JSON file to it in the Unity Inspector.
    public TextMeshProUGUI UI_text; //The UI_text variable is declared as a public TextMeshProUGUI, which allows you to assign a TextMeshPro UI element to it in the Unity Inspector. This is where the information from the JSON file will be displayed.
    public TextMeshProUGUI UI_text2;
    public TextMeshProUGUI UI_text3;
 
    public Image UIimg; //Public reference to canvas object that has image component on it
  
    public int ArrayNum; //The ArrayNum variable is declared as a public integer, which allows you to specify which element of the solar_panels array to display information for.



    //The Player class is declared, which has the [System.Serializable] attribute.
    //This means that the class can be serialized and deserialized to and from JSON.
    //The class has three public variables: panel_id (a string), temperature (an integer), and status (a boolean).

    [System.Serializable]

    public class Player

    {
        public string panel_id;
        public int temperature;
        public bool status;
    }


    //The Playerlist class is declared, which has a public Player[] array called solar_panels
    //This is where the information from the JSON file will be stored.

    

    public class Playerlist
    {
        public Player[] solar_panels;
    }

    public Playerlist myPlayerList = new(); //The myPlayerList variable is declared as a new instance of the Playerlist class.



   


        //The Start method is called before the first frame update. This is where the JSON file is read and parsed.

        void Start  ()
    {

        myPlayerList = JsonUtility.FromJson<Playerlist>(textJSON.text); //The myPlayerList variable is assigned the result of calling JsonUtility.FromJson with the text property of the textJSON variable as the argument. This deserializes the JSON file into a Playerlist object.

        //panel_id
        UI_text.text = "ID: " + myPlayerList.solar_panels[ArrayNum].panel_id; //The UI_text.text property is assigned the string "ID: " concatenated with the panel_id property of the ArrayNum-th element of the solar_panels array. This displays the panel ID in the UI.

         //temperature
        UI_text2.text = "Temp: " + myPlayerList.solar_panels[ArrayNum].temperature.ToString() + " deg"; //The UI_text.text property is then concatenated with a newline character, the string "Temp: ", the temperature property of the ArrayNum-th element of the solar_panels array (converted to a string), and the string " deg". This displays the panel temperature in the UI.

        //status
        UI_text3.text = "Status: " + myPlayerList.solar_panels[ArrayNum].status.ToString(); //The UI_text.text property is then concatenated with another newline character, the string "Status: ", and the status property of the ArrayNum-th element of the solar_panels array (converted to a string). This displays the panel status in the UI.


        ///Set image panel color


      if (myPlayerList.solar_panels[ArrayNum].temperature > 25)
        {
            UIimg.color = Color.red;//set image component of UI panel to red
        }
        else
        {
            UIimg.color = Color.green;//set image component of UI panel to green

        };


        /*this.GetComponent<MeshRenderer>().material.color = Color.green;
        

        this.transform.localScale += new Vector3(1, 2, 1);*/

    }
}
