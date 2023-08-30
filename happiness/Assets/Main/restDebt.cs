using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestDebt : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI restDebt_Count;
    public nagato player;
    public int Debt = 1000000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // テキストの表示を入れ替える
        restDebt_Count.text = "残り" + Debt;

        Debt = Debt - player.getGold;
    }
}
