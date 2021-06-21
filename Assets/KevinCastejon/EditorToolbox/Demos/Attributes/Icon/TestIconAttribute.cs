using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KevinCastejon.EditorToolbox;

public class TestIconAttribute : MonoBehaviour
{
    [Icon("Assets/KevinCastejon/EditorToolbox/Demos/Attributes/Icon/Icons/greencrossicon.png")]
    [SerializeField] private int _healthPoints;
    [Icon("Assets/KevinCastejon/EditorToolbox/Demos/Attributes/Icon/Icons/atk.png")]
    [SerializeField] private int _damages;
}
