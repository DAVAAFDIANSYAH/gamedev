using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Untuk load scene


public class CollectPoin : MonoBehaviour
{
    public int totalPoin = 0;
    public TextMeshProUGUI poinText;
    [SerializeField] private GameObject winpanel;

    public void TambahPoin(int jumlah)
    {
        totalPoin += jumlah;
        UpdateUI();

        if (totalPoin == 5)
        {
            winpanel.SetActive(true);
            Time.timeScale = 0f;
        }

    }

    private void UpdateUI()
    {
        if (poinText != null)
            poinText.text = "Poin: " + totalPoin;
    }

    private void LoadLevel2()
    {
        SceneManager.LoadScene("Level2"); // Pastikan scene "Level2" sudah ditambahkan di Build Settings
    }

  
}
