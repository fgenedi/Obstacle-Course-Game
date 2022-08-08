using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Ground") && !collision.gameObject.CompareTag("Hit"))
        {
            hits++;
            Debug.Log("Number of times you have bumped into objects: " + hits);
        }
    }
}
