using UnityEngine;

public class FileReader : MonoBehaviour
{
    public TextAsset resourceData;
    public TextAsset inputData;

    void Start()
    {
        ResourceProducts productsInJson = JsonUtility.FromJson<ResourceProducts>(resourceData.text);
        NonSynchronizedProducts inputDataInJson = JsonUtility.FromJson<NonSynchronizedProducts>(inputData.text);

        foreach (NonSynchronizedProduct product in inputDataInJson.products)
        {
            foreach (ResourceProduct item in productsInJson.products)
            {
                if (product.option.ToString() == item.qty.ToString())
                {
                    Debug.Log(item.id1c.ToString());
                }
            }
        }

        
    }
}