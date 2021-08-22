using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject ShopMenu;
    void Start()
    {
        if (ShopMenu == null) return;
        ShopMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenShopMenu()
    {
        ShopMenu.SetActive(true);
    }

    public void CloseShopMenu()
    {
        ShopMenu.SetActive(false);
    }
}
