using UnityEngine;

public class BassicEnemy : Enemy
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			if (player != null)
			{
				player.takeDame(enterDamege);
			}
		}
	}

	private void OnTriggerStay2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			if (player != null)
			{
				player.takeDame(stayrDamege);
			}
		}
	}
}
