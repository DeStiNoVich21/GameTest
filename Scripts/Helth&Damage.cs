using UnityEngine;


public class ItemTrigger : MonoBehaviour
{
    public bool isPlayerInRange = false;
    private bool isPlayer1InRange = false;
    private bool isPlayer2InRange = false;
    public int health = 100;

    void Update()
    {

        if (isPlayer1InRange && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Player 1 атакует объект.");
            TakeDamage(20);
        }

        if (isPlayer2InRange && Input.GetKeyDown(KeyCode.RightShift))
        {
            Debug.Log("Player 2 атакует объект.");
            TakeDamage(25);
        }
    }


    public void TakeDamage(int damage)
    {
        health -= damage;
        Transform helthBar = transform.GetChild(0).transform;
        helthBar.localScale = new Vector3(
            helthBar.localScale.x - 0.2f,
            helthBar.localScale.y,
            helthBar.localScale.z);

        if (health <= 0)
        {
            Destroy(gameObject);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayer1InRange = true;
            Debug.Log("Player 1 вошел в зону предмета.");
        }
        else if (other.CompareTag("Player2"))
        {
            isPlayer2InRange = true;
            Debug.Log("Player 2 вошел в зону предмета.");
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayer1InRange = false;
            Debug.Log("Player 1 вышел из зоны предмета.");
        }
        else if (other.CompareTag("Player2"))
        {
            isPlayer2InRange = false;
            Debug.Log("Player 2 вышел из зоны предмета.");
        }


    }


   
}




