using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class EventOnPoints : MonoBehaviour
{
    public int pointsToWin = 1;

    public UnityEvent OnAddPoint;
    public UnityEvent OnWin;

    public TextMeshPro text;

    public int currentPoints;
    public bool won;



    void Update()
    {
        if (!won)
        {
            if (currentPoints >= pointsToWin)
            {
                won = true;
                currentPoints = 0;
                OnWin.Invoke();
            }
        }
    }

    public void AddOnePoint()
    {
        if (!won)
        {
            currentPoints++;
            OnAddPoint.Invoke();

            if (text != null)
            {
                text.text = currentPoints.ToString();
            }
        }

    }


}
