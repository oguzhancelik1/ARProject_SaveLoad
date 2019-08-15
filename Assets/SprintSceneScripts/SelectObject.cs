﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.UI;

public class SelectObject : InstantiationObject
{
   
    public int counter;
    //Layer that holds the created objects which will collide with the raycast
    int layerMask = 1 << 9 |  1<<5;
    GameObject temporary;
    public int countStep = 0;
    
    public static string hit_instance_name;
    public int hit_instance_id;
    public string tag;
    public Text StepUIText;
    //holds whichever object is added from the generative objects
    public GameObject currentObject;

    
    

    #region moving on x,y,z
    //move the last selected object +x direction with the click on button Move_Object_on_X_Positive
    public void Move_Object_on_X_Positive()
    {
        //get the last touched object
        currentObject = GameObject.Find(tag);


        Dictionary<string, float> dict = new Dictionary<string, float>();

        //get the latest version of the string value that holds the information on the object
        string a = PlayerPrefs.GetString(tag);

        //Convert the string back to dictionary for manipulation
        dict = ConvertStringToDict(a);

        //change the location on +x
        currentObject.transform.localPosition = new Vector3(currentObject.transform.localPosition.x + 1, currentObject.transform.localPosition.y, currentObject.transform.localPosition.z);

        //Update the dictionary
        dict["PosX"] = currentObject.transform.localPosition.x;
        //FillDictionary(dict,"PosZ", currentObject.transform.localPosition.z);

        //Convert the dictionary back to the string to set the playerprefs
        a = ConvertDictToString(dict, a);
        Debug.Log(a);
        //save the new string for the object
        PlayerPrefs.SetString(tag, a);
        Debug.Log("New position data stored.");
    }
    //move the last selected object -x direction with the click on button Move_Object_on_X_Negative
    public void Move_Object_on_X_Negative()
    {
        //get the last touched object
        currentObject = GameObject.Find(tag);


        Dictionary<string, float> dict = new Dictionary<string, float>();

        //get the latest version of the string value that holds the information on the object
        string b = PlayerPrefs.GetString(tag);

        //Convert the string back to dictionary for manipulation
        dict = ConvertStringToDict(b);

        //change the location on -x
        currentObject.transform.localPosition = new Vector3(currentObject.transform.localPosition.x - 1, currentObject.transform.localPosition.y, currentObject.transform.localPosition.z);

        //Update the dictionary
        dict["PosX"] = currentObject.transform.localPosition.x;
        //FillDictionary(dict,"PosZ", currentObject.transform.localPosition.z);

        //Convert the dictionary back to the string to set the playerprefs
        b = ConvertDictToString(dict, b);
        Debug.Log(b);
        //save the new string for the object
        PlayerPrefs.SetString(tag, b);
        Debug.Log("New position data stored.");
    }
    //move the last selected object +y direction with the click on button Move_Object_on_Y_Positive
    public void Move_Object_on_Y_Positive()
    {
        //get the last touched object
        currentObject = GameObject.Find(tag);


        Dictionary<string, float> dict = new Dictionary<string, float>();

        //get the latest version of the string value that holds the information on the object
        string c = PlayerPrefs.GetString(tag);

        //Convert the string back to dictionary for manipulation
        dict = ConvertStringToDict(c);

        //change the location on +y
        currentObject.transform.localPosition = new Vector3(currentObject.transform.localPosition.x, currentObject.transform.localPosition.y + 1, currentObject.transform.localPosition.z);

        //Update the dictionary
        dict["PosY"] = currentObject.transform.localPosition.y;
        //FillDictionary(dict,"PosZ", currentObject.transform.localPosition.z);

        //Convert the dictionary back to the string to set the playerprefs
        c = ConvertDictToString(dict, c);
        Debug.Log(c);
        //save the new string for the object
        PlayerPrefs.SetString(tag, c);
        Debug.Log("New position data stored.");
    }
    //move the last selected object -y direction with the click on button Move_Object_on_Y_Negative
    public void Move_Object_on_Y_Negative()
    {
        //get the last touched object
        currentObject = GameObject.Find(tag);


        Dictionary<string, float> dict = new Dictionary<string, float>();

        //get the latest version of the string value that holds the information on the object
        string d = PlayerPrefs.GetString(tag);

        //Convert the string back to dictionary for manipulation
        dict = ConvertStringToDict(d);

        //change the location on -y
        currentObject.transform.localPosition = new Vector3(currentObject.transform.localPosition.x, currentObject.transform.localPosition.y - 1, currentObject.transform.localPosition.z );

        //Update the dictionary
        dict["PosY"] = currentObject.transform.localPosition.y;
        //FillDictionary(dict,"PosZ", currentObject.transform.localPosition.z);

        //Convert the dictionary back to the string to set the playerprefs
        d = ConvertDictToString(dict, d);
        Debug.Log(d);
        //save the new string for the object
        PlayerPrefs.SetString(tag, d);
        Debug.Log("New position data stored.");
    }
    //move the last selected object +z direction with the click on button Move_Object_on_Z_Positive
    public void Move_Object_on_Z_Positive()
    {
        //get the last touched object
        currentObject = GameObject.Find(tag);


        Dictionary<string, float> dict = new Dictionary<string, float>();

        //get the latest version of the string value that holds the information on the object
        string e = PlayerPrefs.GetString(tag);

        //Convert the string back to dictionary for manipulation
        dict = ConvertStringToDict(e);

        //change the location on -z
        currentObject.transform.localPosition = new Vector3(currentObject.transform.localPosition.x, currentObject.transform.localPosition.y, currentObject.transform.localPosition.z + 1);

        //Update the dictionary
        dict["PosZ"] = currentObject.transform.localPosition.z;
        //FillDictionary(dict,"PosZ", currentObject.transform.localPosition.z);

        //Convert the dictionary back to the string to set the playerprefs
        e = ConvertDictToString(dict, e);
        Debug.Log(e);
        //save the new string for the object
        PlayerPrefs.SetString(tag, e);
        Debug.Log("New position data stored.");
    }
   


    //move the last selected object -z direction with the click on button Move_Object_on_Z_Negative
    public void Move_Object_on_Z_Negative()
    {
        //get the last touched object
        currentObject = GameObject.Find(tag);

        
        Dictionary<string, float> dict = new Dictionary<string, float>();

        //get the latest version of the string value that holds the information on the object
        string f = PlayerPrefs.GetString(tag);

        //Convert the string back to dictionary for manipulation
        dict = ConvertStringToDict(f);

        //change the location on -z
        currentObject.transform.localPosition = new Vector3(currentObject.transform.localPosition.x, currentObject.transform.localPosition.y, currentObject.transform.localPosition.z - 1);

        //Update the dictionary
        dict["PosZ"] = currentObject.transform.localPosition.z;
        //FillDictionary(dict,"PosZ", currentObject.transform.localPosition.z);

        //Convert the dictionary back to the string to set the playerprefs
        f = ConvertDictToString(dict, f);
        Debug.Log(f);
        //save the new string for the object
        PlayerPrefs.SetString(tag, f);
        Debug.Log("New position data stored.");
    }
    #endregion

    #region resetplayerprefs function
    public void ResetPlayerPrefs()
    {



        //if (PlayerPrefs.HasKey("DistinctiveNumber"))
        //{
        //    PlayerPrefs.DeleteKey("DistinctiveNumber");
        //    Debug.Log("DistinctiveNumber is deleted");
        //}
        //else
        //{
        //    Debug.Log("DistinctiveNumber doesnt exists");
        //}


        //if (PlayerPrefs.HasKey("1"))
        //{
        //    PlayerPrefs.DeleteKey("1");
        //    Debug.Log("1 is deleted");
        //}
        //else
        //{
        //    Debug.Log("1 doesnt exists");
        //}


        //if (PlayerPrefs.HasKey("2"))
        //{
        //    PlayerPrefs.DeleteKey("2");
        //    Debug.Log("2 is deleted");
        //}
        //else
        //{
        //    Debug.Log("2 doesnt exists");
        //}

        //if (PlayerPrefs.HasKey("3"))
        //{
        //    PlayerPrefs.DeleteKey("3");
        //    Debug.Log("3 is deleted");
        //}
        //else
        //{
        //    Debug.Log("3 doesnt exists");
        //}

        //if (PlayerPrefs.HasKey("4"))
        //{
        //    PlayerPrefs.DeleteKey("4");
        //    Debug.Log("4 is deleted");
        //}
        //else
        //{
        //    Debug.Log("4 doesnt exists");
        //}

        //if (PlayerPrefs.HasKey("5"))
        //{
        //    PlayerPrefs.DeleteKey("5");
        //    Debug.Log("5 is deleted");
        //}
        //else
        //{
        //    Debug.Log("5 doesnt exists");
        //}

        //float stepChecker = PlayerPrefs.GetFloat("Step");

        //Debug.Log("dist num is : " + distinctiveNumber);

        //Debug.Log("We are in step number : " + stepChecker);


    }
    #endregion


    public void OnClickNext()
    {   //restore distinctive number and the current step
        int numberofObjects = PlayerPrefs.GetInt("DistinctiveNumber");
        float currentStep = PlayerPrefs.GetFloat("Step");
        //Increment the current step 
        currentStep++;
        //Update the step text
        StepUIText.text = "Step " + currentStep.ToString();
        //
        PlayerPrefs.SetFloat("Step", currentStep);
        //variable to hold string version of the counter in the for loop
        string counterString;
        //variable to hold the restored object string data
        string keyStringHolder;
        //Variables to hold the gameobject's renderer and collider components which will be enabled or disabled depending on the current step value
        Collider collider;
        Renderer renderer;
        //Dictionary variable is going to be used to compare objects Step value(the step it was created) to the current step value
        Dictionary<string, float> dict = new Dictionary<string, float>();
        //Gameobject variable to access the gameobjects
        GameObject go;
        
        //for loop will iterate for all objectsstarting from the first until it finishes with the last object created.
        for(int counter=1; counter<=numberofObjects; counter++)
        {   
            //Convert counter to string
            counterString = counter.ToString();
            //Get the corresponding objects data
            keyStringHolder = PlayerPrefs.GetString(counterString);
            //Convert the data to dictionary type to access its step value
            dict = ConvertStringToDict(keyStringHolder);
           
            //Compare current step and the object's step value
            if (dict["StepValue"]==currentStep)
            {
                //Enable renderer and collider components of the object
                go = GameObject.Find(counterString);
                renderer = go.GetComponent<MeshRenderer>();
                collider = go.GetComponent<Collider>();
                renderer.enabled = true;
                collider.enabled = true;
            }
            else
            {
                //Disable renderer and collider components of the object
                go = GameObject.Find(counterString);
                renderer = go.GetComponent<MeshRenderer>();
                collider = go.GetComponent<Collider>();
                renderer.enabled = false;
                collider.enabled = false;
            }
        }
       
    }
    public void OnClickPrevious()
    {
        //restore distinctive number and the current step
        int numberofObjects = PlayerPrefs.GetInt("DistinctiveNumber");
        float currentStep = PlayerPrefs.GetFloat("Step");
        //Decrement the current step
        currentStep--;
        //Update the step text
        StepUIText.text = "Step " + currentStep.ToString();
        //
        PlayerPrefs.SetFloat("Step", currentStep);
        //variable to hold string version of the counter in the for loop
        string counterString;
        //variable to hold the restored object string data
        string keyStringHolder;
        //Variables to hold the gameobject's renderer and collider components which will be enabled or disabled depending on the current step value
        Collider collider;
        Renderer renderer;
        //Dictionary variable is going to be used to compare objects Step value(the step it was created) to the current step value
        Dictionary<string, float> dict = new Dictionary<string, float>();
        //Gameobject variable to access the gameobjects
        GameObject go;
       

        //for loop will iterate for all objectsstarting from the first until it finishes with the last object created.
        for (int counter = 1; counter <= numberofObjects; counter++)
        {
            //Convert counter to string
            counterString = counter.ToString();
            //Get the corresponding objects data
            keyStringHolder = PlayerPrefs.GetString(counterString);
            //Convert the data to dictionary type to access its step value
            dict = ConvertStringToDict(keyStringHolder);

            //Compare current step and the object's step value
            if (dict["StepValue"] == currentStep)
            {
                //Enable renderer and collider components of the object
                go = GameObject.Find(counterString);
                renderer = go.GetComponent<MeshRenderer>();
                collider = go.GetComponent<Collider>();
                renderer.enabled = true;
                collider.enabled = true;
            }
            else
            {
                //Disable renderer and collider components of the object
                go = GameObject.Find(counterString);
                renderer = go.GetComponent<MeshRenderer>();
                collider = go.GetComponent<Collider>();
                renderer.enabled = false;
                collider.enabled = false;
            }
        }
        


    }

    void Start()
    {
        PlayerPrefs.SetFloat("Step", 1);
    }

    void Update()
    {

        
        if (Input.GetMouseButtonDown(0))
        {
            //create ray and RaycastHit objects
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            int currentObjectCount;
           

            //check if the ray collides with the objects 
            if (Physics.Raycast(ray, out hit, layerMask))
            {
                //Get GameObject and log its position
                GameObject HitObjectGO = hit.transform.gameObject;
                //Debug.Log("Hit GameObject Position X is: " + HitObjectGO.transform.position.x);
                //Debug.Log("Hit GameObject Position Y is: " + HitObjectGO.transform.position.y);
                //Debug.Log("Hit GameObject Position Z is: " + HitObjectGO.transform.position.z);

                //Get GameObject and log its id
                DistinctiveSphereData distinctiveSphereData_ = HitObjectGO.GetComponent<DistinctiveSphereData>();
                //Get the distinctive id and hold it in a string variable for later use when accessing the touched gameobject
                tag = distinctiveSphereData_.id.ToString();
                HitObjectGO.name = tag;
                
                Debug.Log("Hit GameObject saved ID: " + distinctiveSphereData_.id);
                Debug.Log("Pos X " + HitObjectGO.transform.position.x);
                Debug.Log("Pos Y " + HitObjectGO.transform.position.y);
                Debug.Log("Pos Z " + HitObjectGO.transform.position.z);
                currentObjectCount = PlayerPrefs.GetInt("DistinctiveNumber");

                //get the collided objects name
                hit_instance_name = hit.transform.name;
                Debug.Log("Hit GameObject name"+ hit_instance_name);
                Debug.Log("Total number of objects are : "+ currentObjectCount); 
            }
        }
    }
}


