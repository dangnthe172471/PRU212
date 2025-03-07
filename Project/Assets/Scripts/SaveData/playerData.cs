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
    private Player p;

    public static playerData Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }
    void Start()
    {
        path = Application.dataPath + "/playerData.json";
    }
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.I))
        //{
        //    SavePlayer();
        //}
        //if (Input.GetKeyDown(KeyCode.O))
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
    public void ResetPlayer()
    {
      
        if (File.Exists(path))
        {
            File.Delete(path);
        }

        // 2. Đặt lại vị trí Player về mặc định
        if (player != null)
        {
            player.position = new Vector3(0, 0, 0);
            Debug.Log("Đã đặt lại vị trí Player về mặc định!");
        }
    }
}
