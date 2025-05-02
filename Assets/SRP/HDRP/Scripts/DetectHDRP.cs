// assembly definition requires at least one script

namespace SRPDetectionHDRP
{
    public static class DetectHDRP
    {
        // now can use defines here
#if HDRP_INSTALLED
        public static bool IsHDRPInstalled = true;
#else
        public static bool IsHDRPInstalled = false;
#endif

    }
}
