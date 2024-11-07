using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleHandler : MonoBehaviour
{
    private int count; // How many collectibles collected.
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    // Start is called before the first frame update
    void Start()
    {
        SetCountText();
        winTextObject.SetActive(false);
    }

    private void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }


    // Called when collides with trigger
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        count++;
        SetCountText();
        if(count >= 12)
        {
            winTextObject.SetActive(true);
        }
    }
}
