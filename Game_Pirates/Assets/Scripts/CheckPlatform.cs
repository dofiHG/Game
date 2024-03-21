using UnityEngine;

public class CheckPlatform : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite;

    private void OnTriggerExit2D(Collider2D collision)
    {    
        sprite.enabled = false;
    }
}
