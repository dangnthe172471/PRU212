using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
	[SerializeField] private float moveSpeed = 25f;
	[SerializeField] private float timeDestroy = 0.5f;
	[SerializeField] private float damege = 10f;
	[SerializeField] GameObject bloodPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
	{
		Destroy(gameObject, timeDestroy);
	}

	// Update is called once per frame
	void Update()
	{
		MoveBullet();
	}
	void MoveBullet()
	{
		transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
	}

	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.CompareTag("Enemy"))
		{
			Enemy enemy = collider.GetComponent<Enemy>();
			if (enemy != null)
			{ 
				enemy.takeDame(damege );
				GameObject blood = Instantiate(bloodPrefabs, transform.position, Quaternion.identity);
				Destroy(blood, 1f);
			}
			Destroy(gameObject);
		}
	}
}
