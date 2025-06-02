using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    // 1. Variabel public
    public int playerHP = 100;
    public int healAmount = 20;
    public int enemyAttackPower = 30;

    // 2. Fungsi mengambil damage
    public int TakeDamage(int damage)
    {
        playerHP -= damage;
        return playerHP;
    }

    // 3. Fungsi menyembuhkan
    public int Heal(int amount)
    {
        playerHP += amount;
        return playerHP;
    }

    // 4. Fungsi mengecek apakah pemain mati
    public bool IsDead()
    {
        return playerHP <= 0;
    }

    // Fungsi Start untuk menjalankan simulasi
    void Start()
    {
        Debug.Log("HP Awal: " + playerHP);

        // Pemain terkena serangan
        int hpAfterDamage = TakeDamage(enemyAttackPower);
        Debug.Log("Setelah diserang: " + hpAfterDamage);

        // Pemain disembuhkan
        int hpAfterHeal = Heal(healAmount);
        Debug.Log("Setelah disembuhkan: " + hpAfterHeal);

        // Mengecek status hidup atau mati
        bool deadStatus = IsDead();
        if (deadStatus)
        {
            Debug.Log("Pemain sudah mati.");
        }
        else
        {
            Debug.Log("Pemain masih hidup.");
        }
    }
}
