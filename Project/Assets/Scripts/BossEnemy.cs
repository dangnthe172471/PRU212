using UnityEngine;

public class BossEnemy : Enemy
{
    private void OnTriggerEnter2D(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.takeDame(enterDamege);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.takeDame(stayDamage);
        }
    }

    private void BanDanThuong()
    {

    }

    private void BanDanTron()
    {

    }

    private void HoiMau()
    {

    }

    private void CreateMiniEnemy()
    {

    }

    private void DichChuyen()
    {

    }
}
