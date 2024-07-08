using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingUi : MonoBehaviour
{
    [field: SerializeField] public GameObject Player { get; set; }
    public static SettingUi Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(this);
    }
}
