using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int ArrowCount = 0;

    public Text text;

    void Start()
    {
        ArrowCount = 0;
    }

    void Update()
    {
        text.text = ArrowCount.ToString();
    }
}
