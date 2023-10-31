using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;
    private int hearts = 0;

    [SerializeField] private TMP_Text cherriesText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Cherries: " + cherries;
        }
        if (collision.gameObject.CompareTag("Heart"))
        {
            Destroy(collision.gameObject);
            hearts++;
            cherriesText.text = "Heart: " + hearts;
        }
    }
}
