using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollectPoin2 : MonoBehaviour
{
    public CollectPoin2 collectPoin;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Poin"))
        {
            collectPoin.TambahPoin(1); // Tambah 1 tiap poin
            Destroy(other.gameObject); // Hapus poin dari scene
        }
    }
}
