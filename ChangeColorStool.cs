using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColourStool : MonoBehaviour
{
    [SerializeField]
    public GameObject stool;

    private Renderer stoolRenderer;

    private Color newStoolColor;

    private float randomChannelOne, randomChannelTwo, RandomChannelThree;

    // Start is called before the first frame update
    void Start()
    {
        stoolRenderer = stool.GetComponentInChildren<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(changeStoolColor);

    }

    private void changeStoolColor()
    {
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        RandomChannelThree = Random.Range(0f, 1f);

        newStoolColor = new Color(randomChannelOne, randomChannelTwo, RandomChannelThree, 1f);

        stoolRenderer.material.SetColor("_Color", newStoolColor);
    }
}
