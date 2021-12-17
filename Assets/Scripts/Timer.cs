using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timer;
    [SerializeField] private float time;
    private float currentTime;

    private void Start()
    {

        currentTime = time;
    }

    void Update()
    {
        time -= Time.deltaTime;
        timer.text = Mathf.Round(time).ToString();
    }
}