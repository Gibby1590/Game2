using UnityEngine;
using UnityEngine.InputSystem;
public class Mouse : MonoBehaviour
{
    [SerializeField] private float sensibilidadMouse;
    protected Vector2 mira;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void OnLook(InputValue value)
    {
        mira=value.Get<Vector2>();
    }
    void Move()
    {
        float rotactionY=mira.x * sensibilidadMouse * Time.deltaTime;
        transform.Rotate(0, rotactionY, 0);
    }
}
