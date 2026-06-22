using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : Character
{
    
    [SerializeField] private TextMeshProUGUI vidas;
    [SerializeField] private TextMeshProUGUI monedasText;
    [SerializeField] private TextMeshProUGUI winText;
    private int monedasColectadas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(winText != null)
        {
            winText.gameObject.SetActive(false);
        }
        vidas.text += 10;
        
    }
        void OnTriggerEnter(Collider collision)    
        {
        Debug.Log("tfgh");
        if (collision.gameObject.CompareTag("Monedas"))
        {
            Debug.Log("tfgh");
            monedasColectadas++;
            ActualizarTexto();
            if(monedasColectadas >= 10)
            {
                MostrarWin();
            }
            Destroy(collision.gameObject);
        }
    }
    void ActualizarTexto()
    {
        monedasText.text="Monedas:" + monedasColectadas;
    }
    void MostrarWin()
    {
        winText.text = "Pos ganaste";
        winText.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        Mover();
    }
    public void OnMove(InputValue inputValue)
    {
        inputMove = inputValue.Get<Vector2>();
    }

    public void Mover()
    {
        base.Move();
    }


}
