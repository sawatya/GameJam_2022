using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableElement : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if (player)
        {
            player.numberChest++;
            Destroy(this.gameObject);
        }
    }
}
