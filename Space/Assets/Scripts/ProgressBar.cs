using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] GameObject playerGO;
    [SerializeField] GameObject FinnishGO;
    [SerializeField] Slider target;
    Image progressBar;
    float maxDistance;

    // Start is called before the first frame update
    void Start()
    {
        progressBar = GetComponent<Image>();
        maxDistance = FinnishGO.transform.position.y;

        progressBar.fillAmount = playerGO.transform.position.y / maxDistance;
    }

    // Update is called once per frame
    void Update()
    {
        target.value = playerGO.transform.position.y / maxDistance;
    }
}