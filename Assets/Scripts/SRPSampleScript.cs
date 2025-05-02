// prints out info if URP or HDRP is installed in this project

using UnityEngine;

namespace SRPDetection.Sample
{
    public class SRPSampleScript : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("Detecting installed SRP..");

            // can use static check, or could add same Version Define check into current AssemblyDefinition
            if (SRPDetectionURP.DetectURP.IsURPInstalled)
            {
                Debug.Log("URP is <color=green>installed</color>");
            }
            else
            {
                Debug.Log("URP <color=red>not installed</color>");
            }

            if (SRPDetectionHDRP.DetectHDRP.IsHDRPInstalled)
            {
                Debug.Log("HDRP is <color=green>installed</color>");
            }
            else
            {
                Debug.Log("HDRP <color=red>not installed</color>");
            }

            if (SRPDetectionURP.DetectURP.IsURPInstalled && SRPDetectionHDRP.DetectHDRP.IsHDRPInstalled)
            {
                Debug.Log("URP AND HDRP are <color=green>installed</color>, How???");
            }
            else
            {
                Debug.Log("BIRP is best and its <color=green>installed</color>!");
            }
        }

    }
}
