using UnityEngine;
using UnityEngine.UI;

public abstract class Enemy : MonoBehaviour
{
	[SerializeField] protected float moveSpeed = 1.0f;

	protected Player player;

	[SerializeField] protected float maxHp=50f;
	protected float currentHp;
	[SerializeField] private Image hpBar;

	[SerializeField] protected float enterDamege=10f;
	[SerializeField] protected float stayDamage=1f;

	protected virtual void Start()
	{
		player = FindAnyObjectByType<Player>();
		currentHp = maxHp;
		updateHpBar();
	}
	protected virtual void Update()
	{
		moveToPlayer();
	}

	protected void moveToPlayer()
	{
		if (player != null)
		{
			transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
			flipEnemy();
		}
	}

	protected void flipEnemy()
	{
		if (player != null)
		{
			transform.localScale = new Vector3(player.transform.position.x < transform.position.x ? -1 : 1, 1, 1);
		}
	}
	public virtual void takeDame(float damege)
	{
		currentHp -= damege;
		currentHp = Mathf.Max(currentHp, 0);
		updateHpBar();
		if (currentHp <= 0)
		{
			die();
		}
	}
	protected virtual void die()
	{
		Destroy(gameObject);
	}
	protected void updateHpBar()
	{
		if (hpBar != null)
		{
			hpBar.fillAmount = currentHp / maxHp;
		}
	}
}
