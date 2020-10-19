﻿using UnityEngine;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoad : MonoBehaviour
{
    public static void Save<T>(T objectToSave, string key)
    {
        string path = Application.persistentDataPath + "/Saves/";
        Directory.CreateDirectory(path);
        BinaryFormatter formatter = new BinaryFormatter();

        using (FileStream fileStream = new FileStream(path + key + ".txt", FileMode.Create))
        {
            formatter.Serialize(fileStream, objectToSave);
        }
    }

    public static T Load<T>(string key)
    {
        string path = Application.persistentDataPath + "/Saves/";
        BinaryFormatter formatter = new BinaryFormatter();
        T returnValue = default(T);

        using (FileStream fileStream = new FileStream(path + key + ".txt", FileMode.Open))
        {
            returnValue = (T)formatter.Deserialize(fileStream);
        }

        return returnValue;
    }

    public static bool SaveExists(string key)
    {
        string path = Application.persistentDataPath + "/Saves/" + key + ".txt";
        return File.Exists(path);
    }

    public static void DeleteAllSavefiles()
    {
        string path = Application.persistentDataPath + "/Saves/";
        DirectoryInfo directory = new DirectoryInfo(path);
        directory.Delete();
        Directory.CreateDirectory(path);
    }
}
