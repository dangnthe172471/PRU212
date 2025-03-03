using UnityEngine;
using System.IO;


[System.Serializable]
public class PlayerData
{
    public float x, y, z;
}
public class playerData : MonoBehaviour
{
    public Transform player; // Kéo Player vào đây trong Unity Inspector
    private string path;

    void Start()
    {
        path = Application.persistentDataPath + "/playerData.json";
    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S)) 
        //{
        //    SavePlayer();
        //}
        //if (Input.GetKeyDown(KeyCode.L)) 
        //{
        //    LoadPlayer();
        //}
    }
    public void SavePlayer()
    {
        if (player == null)
        {
            Debug.LogWarning("Player chưa được gán vào PlayerSave!");
            return;
        }

        PlayerData data = new PlayerData
        {
            x = player.position.x,
            y = player.position.y,
            z = player.position.z
        };

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(path, json);
        Debug.Log(" Đã lưu tọa độ Player: " + json);
    }

    public void LoadPlayer()
    {
        if (player == null)
        {
            Debug.LogWarning(" Player chưa được gán vào PlayerSave!");
            return;
        }

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            PlayerData data = JsonUtility.FromJson<PlayerData>(json);

            player.position = new Vector3(data.x, data.y, data.z);
            Debug.Log("Đã load vị trí Player từ JSON: " + json);
        }
        else
        {
            Debug.LogWarning("" +
                "2 Không tìm thấy file JSON để load!");
        }
    }
}
