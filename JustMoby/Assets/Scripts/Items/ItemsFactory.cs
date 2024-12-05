using System.Collections.Generic;
using UnityEngine;

public class ItemsFactory : MonoBehaviour
{
    [SerializeField] private ItemView _itemPrefab;
    [SerializeField] private int _preInstantiateCount = 3;

    private Stack<ItemView> _activeItems = new Stack<ItemView>();
    private Stack<ItemView> _inactiveItems = new Stack<ItemView>();

    private void Awake()
    {
        for (int i = 0; i < _preInstantiateCount; i++)
        {
            ItemView newItem = Instantiate(_itemPrefab.gameObject, transform).GetComponent<ItemView>();
            newItem.gameObject.SetActive(false);
            _inactiveItems.Push(newItem);
        }
    }

    public ItemView GetItem()
    {
        ItemView item;
        if (_inactiveItems.Count > 0)
        {
            item = _inactiveItems.Pop();
        }
        else
        {
            item = Instantiate(_itemPrefab.gameObject, transform).GetComponent<ItemView>();
        }
        item.gameObject.SetActive(true);
        _activeItems.Push(item);
        return item;
    }

    public void Refresh()
    {
        ItemView item;
        while (_activeItems.Count > 0)
        {
            item = _activeItems.Pop();
            item.gameObject.SetActive(false);
            _inactiveItems.Push(item);
        }
    }
}
