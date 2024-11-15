using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Mat : MonoBehaviour
{
    [SerializeField] MatSO matSO;
    [SerializeField] int count;
    [SerializeField] TextMeshProUGUI countText;
    [SerializeField] Image image;

    private void Start()
    {
        // init
        count = 0;
        countText.text = count.ToString();

        // change image
        if (matSO.icon != null)

        {
            image.sprite = matSO.icon;
        }
    }
}
