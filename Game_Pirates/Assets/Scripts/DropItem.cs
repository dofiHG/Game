using UnityEngine;

public class DropItem : MonoBehaviour
{
    private GameObject item;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDroppedItem()
    {
        Vector2 dropPosition = new Vector2(player.position.x + 1, player.position.y);
        Instantiate(item, dropPosition, Quaternion.identity);
        Destroy(gameObject);
    }
}
