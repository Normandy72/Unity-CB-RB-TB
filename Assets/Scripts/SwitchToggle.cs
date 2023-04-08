using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SwitchToggle : MonoBehaviour
{
    [SerializeField] private RectTransform _handle;
    [SerializeField] private Color _backgroundActiveColor;
    [SerializeField] private Color _handleActiveColor;

    private Image _backgroundImage, _handleImage;
    private Color _backgroundDefaultColor, _handleDefaultColor;
    private Toggle _toggle;
    private Vector2 _handlePosition;

    private void Awake()
    {
        _toggle = GetComponent<Toggle>();

        _handlePosition = _handle.anchoredPosition;

        _backgroundImage = _handle.parent.GetComponent<Image>();
        _handleImage = _handle.GetComponent<Image>();
        _backgroundDefaultColor = _backgroundImage.color;
        _handleDefaultColor = _handleImage.color;

        _toggle.onValueChanged.AddListener(OnSwitch);

        if(_toggle.isOn)
        {
            OnSwitch(true);
        }
    }

    private void OnSwitch(bool on)
    {
        // multiply by -1 to flip x axis
        //_handle.anchoredPosition = on ? _handlePosition * -1 : _handlePosition;

        _handle.DOAnchorPos(on ? _handlePosition * -1 : _handlePosition, 0.4f).SetEase(Ease.InOutBack);

        //_backgroundImage.color = on ? _backgroundActiveColor : _backgroundDefaultColor;
        _backgroundImage.DOColor(on ? _backgroundActiveColor : _backgroundDefaultColor, 0.6f);

        //_handleImage.color = on ? _handleActiveColor : _handleDefaultColor;
        _handleImage.DOColor(on ? _handleActiveColor : _handleDefaultColor, 0.4f);
    }

    private void OnDestroy()
    {
        _toggle.onValueChanged.RemoveListener(OnSwitch);
    }
}
