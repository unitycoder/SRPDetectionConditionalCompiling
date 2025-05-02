// assembly definition requires at least one script

namespace SRPDetectionURP
{
    public static class DetectURP
    {
        // now can use defines here
#if URP_INSTALLED
        public static bool IsURPInstalled = true;
#else
        public static bool IsURPInstalled = false;
#endif

    }
}
