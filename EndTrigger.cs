using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject completeLevelUI;

    private void Start()
    {
        GameObject.Find("ScoreManager").GetComponent<LevelComplete>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            completeLevelUI.SetActive(true);
        }
    }
}
