using UnityEngine;

public class Arrow : MonoBehaviour
{

    private bool isPinned = false; 
    public float speed = 20f;
    public Rigidbody2D rb;
    


    void Update()
    {
        if(!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    /*public void AdjustArrowSpeed(float newArrowSpeed)
    {
        speed = newArrowSpeed;
    }*/

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.ArrowCount++;
            //col.GetComponent<Rotator>().speed += 25f; // increase roation speed after arrow hit
            //col.GetComponent<Rotator>().speed *= -1; // change rotation direction
            isPinned = true;
        }
        else if (col.tag == "Arrow")
        {
            int lifeCount = PlayerPrefs.GetInt("totalLives");
            lifeCount--;
            Debug.Log("-1 Life");
            if(lifeCount > 0)
            {
                PlayerPrefs.SetInt("totalLives", lifeCount);
                FindObjectOfType<GameManager>().RestartLevel();
            }
            else 
                FindObjectOfType<GameManager>().EndGame();
        }
    }
}
