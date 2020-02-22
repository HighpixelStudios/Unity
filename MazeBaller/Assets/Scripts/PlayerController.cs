using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Threading;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;
    private int currentTime;

    private Rigidbody rb;
    private int count;
    public Text countTime;
    private bool m_ToggleChange;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 8;
        winText.text = "";
        SetCountText();
        currentTime = 8000;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        currentTime -= 1;
        countTime.text = currentTime.ToString("000");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count - 1;
            SetCountText();
        }

    }

    void SetCountText ()
    {
        countText.text = "Coins Needed: " + count.ToString();
        if (count <= 0)
        {
            winText.text = "You Win!";
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
            {
                SceneManager.LoadScene("Level2");
            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2"))
            {
                SceneManager.LoadScene("Level3");
            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3"))
            {
                SceneManager.LoadScene("Level4");
            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level4"))
            {
                SceneManager.LoadScene("Level5");
            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level5"))
            {
                SceneManager.LoadScene("Level6");
            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level6"))
            {
                SceneManager.LoadScene("Level7");
            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level7"))
            {
                Thread.Sleep(10000);
                Application.Quit();
            }

            //StartCoroutine (nextLevel());

        }
    }

    private void Update()
    {
        if (currentTime != 0)
        {
            currentTime -= 1;
            countTime.text = currentTime.ToString("000");
        }


		if (currentTime <= 0)
        {
            winText.text = "You Lost!";
            Time.timeScale = 0;
            //Thread.Sleep(10000);
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
        {
            SceneManager.LoadScene("Level1");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2"))
        {
            SceneManager.LoadScene("Level2");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3"))
        {
            SceneManager.LoadScene("Level3");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level4"))
        {
            SceneManager.LoadScene("Level4");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level5"))
        {
            SceneManager.LoadScene("Level5");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level6"))
        {
            SceneManager.LoadScene("Level6");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level7"))
        {
            SceneManager.LoadScene("Level7");
        }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Death Wall")
        {
            winText.text = "You Lost!";
            currentTime = 0;
            Time.timeScale = 0;
            //Thread.Sleep(10000);
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
            {
                SceneManager.LoadScene("Level1");
            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2"))
            {
                SceneManager.LoadScene("Level2");
            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3"))
            {
                SceneManager.LoadScene("Level3");
            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level4"))
            {
                SceneManager.LoadScene("Level4");
            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level5"))
            {
                SceneManager.LoadScene("Level5");
            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level6"))
            {
                SceneManager.LoadScene("Level6");
            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level7"))
            {
                SceneManager.LoadScene("Level7");
            }
        }
    }

    public void RestartLevel()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
        {
            SceneManager.LoadScene("Level1");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2"))
        {
            SceneManager.LoadScene("Level2");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level3"))
        {
            SceneManager.LoadScene("Level3");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level4"))
        {
            SceneManager.LoadScene("Level4");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level5"))
        {
            SceneManager.LoadScene("Level5");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level6"))
        {
            SceneManager.LoadScene("Level6");
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level7"))
        {
            SceneManager.LoadScene("Level7");
        }
    }




    /*IEnumerator nextLevel()
    {       
        if (sceneName = "SampleScene")
        {
            yield return new WaitForSeconds(2);
            winText.text = "Level 2";
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(1);
        }
    }*/

}
