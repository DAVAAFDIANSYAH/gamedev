using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CollectPoin3 : MonoBehaviour
{
    public int totalPoin = 0;
    public TextMeshProUGUI poinText;
    [SerializeField] private GameObject winpanel;

        

    public void TambahPoin(int jumlah)
    {
        totalPoin += jumlah;
        UpdateUI();

        if (totalPoin == 15)
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

    private void LoadLevel3()
    {
        SceneManager.LoadScene("Level3"); // Pastikan scene "Level2" sudah ditambahkan di Build Settings
    }

  
}
