using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject slotButton;
    [SerializeField] private SpriteRenderer sprite;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        sprite = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    Destroy(gameObject);
                    sprite.enabled = true;
                    Instantiate(slotButton, inventory.slots[i].transform);
                    inventory.isFull[i] = true;
                    break;
                }
            }
        }
    }
} 