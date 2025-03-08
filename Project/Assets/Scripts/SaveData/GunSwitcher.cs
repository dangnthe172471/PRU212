using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private List<Gun> guns = new List<Gun>(); // Danh sách các súng
    private int currentGunIndex = 0; // Chỉ số súng hiện tại

    private void Start()
    {
        EquipGun(currentGunIndex); // Trang bị súng ban đầu
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) SwitchGun(0);
        if (Input.GetKeyDown(KeyCode.Alpha2)) SwitchGun(1);
        if (Input.GetKeyDown(KeyCode.Alpha3)) SwitchGun(2);
    }

    public void SwitchGun(int gunIndex)
    {
        if (gunIndex >= 0 && gunIndex < guns.Count)
        {
            currentGunIndex = gunIndex;
            EquipGun(currentGunIndex);
        }
    }

    private void EquipGun(int index)
    {
        for (int i = 0; i < guns.Count; i++)
        {
            guns[i].gameObject.SetActive(i == index);
        }
    }
}
