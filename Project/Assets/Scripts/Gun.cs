using TMPro;
using UnityEngine;

public class Gun : MonoBehaviour
{
	private float rotateOffset = 180f;
	[SerializeField] private Transform firePos;
	[SerializeField] private GameObject bulletPrefabs;
	[SerializeField] private float shotDelay = 0.15f;
	private float nextShot;
	[SerializeField] private int maxAmmo = 24;
	[SerializeField] private int currentAmmo;

	[SerializeField] private TextMeshProUGUI amoText;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		currentAmmo = maxAmmo;
		updateAmoText();
	}

	// Update is called once per frame
	void Update()
	{
		RotateGun();
		Shot();
		ReLoad();
	}

	void RotateGun()
	{
		if (Input.mousePosition.x < 0 || Input.mousePosition.x > Screen.width || Input.mousePosition.y < 0 || Input.mousePosition.y > Screen.width)
		{
			return;
		}
		Vector3 displacement = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
		float angle = Mathf.Atan2(displacement.y, displacement.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0, 0, angle + rotateOffset);
		if (angle < -90 || angle > 90)
		{
			transform.localScale = new Vector3(1, 1, 1);
		}
		else
		{
			transform.localScale = new Vector3(1, -1, 1);
		}
	}
	void Shot()
	{
		if (Input.GetMouseButtonDown(0) && currentAmmo > 0 && Time.time > 0)
		{
			nextShot = Time.time + shotDelay;
			Instantiate(bulletPrefabs, firePos.position, firePos.rotation);
			currentAmmo--;
			updateAmoText();
		}
	}
	void ReLoad()
	{
		if (Input.GetKeyDown(KeyCode.R) && currentAmmo < maxAmmo)
		{
			currentAmmo = maxAmmo;
			updateAmoText();
		}
	}

	private void updateAmoText()
	{
		if (amoText != null)
		{
			if (currentAmmo > 0)
			{
				amoText.text = currentAmmo.ToString();
			}
			else
			{
				amoText.text = "Empty";
			}
		}
	}
}
