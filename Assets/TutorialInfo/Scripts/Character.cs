using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float vel;
    protected Vector2 inputMove;


    private void Start()
    {

    }
    private void FixedUpdate()
    {
        Move();
    }
    public void Move()
    {


        Vector3 direction = new Vector3(inputMove.x, 0, inputMove.y);
        transform.Translate(direction * vel * Time.deltaTime);
    }
}
