using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	[SerializeField] private GameManager gameManager;

	[SerializeField] private AudioManager audioManager;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("EnemyBullet"))
		{
			Player player = GetComponent<Player>();
			player.takeDame(20f);
		}
		else if (collision.CompareTag("Energy"))
		{
			//gameManager.addE();
			GameObject[] allGuns = GameObject.FindGameObjectsWithTag("Gun");
			foreach (var e in allGuns)
			{
				Gun gun = e.GetComponent<Gun>();
				if (gun != null)
				{
					gun.ActivateBuff(1);
				}
			}
			Destroy(collision.gameObject);
			audioManager.PlayEnerty();
		}else if (collision.CompareTag("HealHp"))
		{
            Player player = GetComponent<Player>();
            player.Heal(player.maxHp);
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Box"))
        {
            Player player = GetComponent<Player>();
            player.Heal(player.maxHp);


            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("ItemBuff")) //tang so luong dan
        {
            Player player = GetComponent<Player>();
            player.Heal(player.maxHp);
            GameObject[] allGuns = GameObject.FindGameObjectsWithTag("Gun");
            foreach (var e in allGuns)
            {
                Gun gun = e.GetComponent<Gun>();
                if (gun != null)
                {
                    gun.ActivateAmmoBuff();
                }
            }
            Destroy(collision.gameObject);
        }else if (collision.CompareTag("coin"))
        {
            goldManager.Instance.AddGold(1);
            Destroy(collision.gameObject);
        }
    }
}
