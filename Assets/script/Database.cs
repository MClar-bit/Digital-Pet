using System.IO;
using UnityEngine;

public class Database
{
    private string path = Application.dataPath +"/Resources/Saves/";
    public void saveData<T>(string saveName, T saveData){
        string JsonSave = JsonUtility.ToJson(saveData);
        File.WriteAllText(path + saveName+".json", JsonSave);
    }

    public void loadData<T>(string saveName, System.Action<T> callback){
        if (File.Exists(path + saveName + ".json")){
            string loadJson = File.ReadAllText(path + saveName + ".json");
            callback(JsonUtility.FromJson<T>(loadJson));
        }else{
            Debug.Log("File Doesn't exsist");
        }
    }
}
