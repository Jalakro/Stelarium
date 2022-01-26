using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropZoneSelector : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Text;
    private int ID_Active;
    // Start is called before the first frame update
    void Start()
    {
        ID_Active = 0;
    }

    public void IncrementDropZoneActive()
    {
        transform.GetChild((ID_Active+1)%transform.childCount).gameObject.SetActive(true);
        transform.GetChild(ID_Active).gameObject.SetActive(false);
        ID_Active = (ID_Active+1)%transform.childCount;
        Text.GetComponent<TextMeshProUGUI>().text = transform.GetChild(ID_Active).name;
    }
    public void DecrementDropZoneActive()
    {
        transform.GetChild(ID_Active).gameObject.SetActive(false);
        ID_Active = ID_Active-1;
        if (ID_Active < 0)
            ID_Active += transform.childCount;
        transform.GetChild(ID_Active).gameObject.SetActive(true);
        Text.GetComponent<TextMeshProUGUI>().text = transform.GetChild(ID_Active).name;
    }

}
