using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    [SerializeField] private ImagesConfig _imagesConfig;
    [SerializeField] private ItemsFactory _itemsFactory;
    [SerializeField] private HorizontalLayoutGroup _topGroup;
    [SerializeField] private HorizontalLayoutGroup _botGroup;

    public void Initialize(IconsViewConfig config)
    {
        _itemsFactory.Refresh();

        for (int i = 0; i < config.Icons.Count; i++)
        {
            ItemView item = _itemsFactory.GetItem();
            if (i < 2)
                item.transform.SetParent(_topGroup.transform);
            else if (i < 4)
                item.transform.SetParent(_botGroup.transform);
            else if (i % 2 == 0)
                item.transform.SetParent(_topGroup.transform);
            else
                item.transform.SetParent(_botGroup.transform);

            Sprite icon = _imagesConfig.GetSpriteByName(config.Icons[i].Name);

            item.Initialize(icon, config.Icons[i].Count.ToString());
            item.transform.localScale = Vector3.one;
            item.gameObject.SetActive(true);
        }
    }
}
