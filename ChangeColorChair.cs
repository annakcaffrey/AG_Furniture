using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColourChair1 : MonoBehaviour
{
    [SerializeField]
    public GameObject chairone;

    private Renderer chaironeRenderer;

    private Color newChairColor;

    private float randomChannelOne, randomChannelTwo, RandomChannelThree;

    // Start is called before the first frame update
    void Start()
    {
        chaironeRenderer = chairone.GetComponentInChildren<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(changeChairColor);

    }

    private void changeChairColor()
    {
        randomChannelOne = Random.Range(0f, 1f);
        randomChannelTwo = Random.Range(0f, 1f);
        RandomChannelThree = Random.Range(0f, 1f);

        newChairColor = new Color(randomChannelOne, randomChannelTwo, RandomChannelThree, 1f);

        chaironeRenderer.material.SetColor("_Color", newChairColor);
    }
}

