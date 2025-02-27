using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	[SerializeField] private float moveSpeed = 5f;
	private Rigidbody2D rb;
	private SpriteRenderer spriteRenderer;
	private Animator animator;

	[SerializeField] private float maxHp = 100f;
	private float currentHp;
	[SerializeField] private Image hpBar;

	[SerializeField] private GameManager gameManager;
	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		animator = GetComponent<Animator>();
	}
	void Start()
	{
		currentHp= maxHp;
		updateHpBar();
	}

	void Update()
	{
		MovePlayer();
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			gameManager.PauseMenu();
		}
	}

	void MovePlayer()
	{
		Vector2 playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		rb.linearVelocity = playerInput * moveSpeed;
		if (playerInput.x < 0)
		{
			spriteRenderer.flipX = true;
		}
		else if (playerInput.x > 0)
		{
			spriteRenderer.flipX = false;
		}
		if (playerInput != Vector2.zero)
		{
			animator.SetBool("isRun", true);
		}
		else
		{
			animator.SetBool("isRun", false);
		}
	}

	public void takeDame(float damege)
	{
		currentHp -= damege;
		currentHp = Mathf.Max(currentHp, 0);
		updateHpBar();
		if (currentHp <= 0)
		{
			die();
		}
	}

	private void die()
	{
		//Destroy(gameObject);
		gameManager.OverMenu();
	}

	private void updateHpBar()
	{
		if (hpBar != null)
		{
			hpBar.fillAmount = currentHp / maxHp;
		}
	}
	public void Heal(float hp)
	{
		if(currentHp < maxHp)
		{
			currentHp += hp;
			currentHp = Mathf.Min(currentHp, maxHp);
			updateHpBar();
		}
	}
}
