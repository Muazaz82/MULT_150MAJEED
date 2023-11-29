using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameCriticc : MonoBehaviour
{

    void CreateText()
    {
        //Path of the file
        string path = Application.dataPath + "/GameCritic.txt";
        //Create File if it doesn't exist
        if (!File.Exists(path))
        {
            File.WriteAllText(path, " GameCritic.txt \n\n");
        }
        //Content of the file
        string content = "answer the questions: " + System.DateTime.Now + "\n";
        //Add some to text to it
        File.AppendAllText(path, content);
    }

    // Use this for initialization
    void Start()
    {
        CreateText();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
