using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    [SerializeField] private GameObject inv;
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.E))  inv.SetActive(!inv.activeSelf); 
    }
}
