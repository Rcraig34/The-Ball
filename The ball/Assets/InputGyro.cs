using UnityEngine;
using UnityEngine.UI;

public class InputGyro : MonoBehaviour
{
    Gyroscope m_Gyro;

    void Start()
    {
        //Set up and enable the gyroscope (check your device has one)
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
    }

}
