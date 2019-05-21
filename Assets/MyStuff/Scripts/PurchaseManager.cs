using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseManager : MonoBehaviour
{

    void Start()
    {

    }

    public void Buy99Coins()
    {
        IAPManager.INSTANCE.BuyCoins99();
    }

    public void Buy499Coins()
    {
        IAPManager.INSTANCE.BuyCoins499();
    }

}
