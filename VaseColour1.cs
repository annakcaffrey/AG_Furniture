using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VaseCol1 : MonoBehaviour
{
    [SerializeField]
    public GameObject vase;

    private Renderer vaseRenderer;

    private Color newVaseColor;

    private float randomChannelOne, randomChannelTwo, RandomChannelThree;

    // Start is called before the first frame update
    void Start()
    {
        vaseRenderer = vase.GetComponentInChildren<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(changeVaseColor);

    }

    private void changeVaseColor()
    {
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        RandomChannelThree = Random.Range(0f, 1f);

        newVaseColor = new Color(randomChannelOne, randomChannelTwo, RandomChannelThree, 1f);

        vaseRenderer.material.SetColor("_Color", newVaseColor);
    }
}
