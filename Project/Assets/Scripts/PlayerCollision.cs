using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Gun gun;

    [SerializeField] private AudioManager audioManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyBullet"))
        {
            Player player = GetComponent<Player>();
            player.takeDame(20f);
        }else if (collision.CompareTag("Energy"))
        {
            gameManager.addE();
			gun.ActivateBuff();
			Destroy(collision.gameObject);

            audioManager.PlayEnerty();
        }
    }


}
