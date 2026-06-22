using UnityEngine;

public class camaras : MonoBehaviour
{
    [SerializeField] private GameObject cameras1;
    [SerializeField] private GameObject cameras2;
    [SerializeField] private GameObject cameras3;
    void Start()
    {
        cameras1.SetActive(true);
        cameras2.SetActive(false);
        cameras3.SetActive(false);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("player"))
        {
        cameras1.SetActive(false);
        cameras2.SetActive(true);
        }
        
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("player"))
        {
        cameras1.SetActive(true);
        cameras2.SetActive(false);
        }
        
    }

}
