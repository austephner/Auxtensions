using UnityEngine;

namespace Auxtensions
{
    public static class QuaternionExtensions
    {
        // TODO: documentation
        public static Quaternion RemoveNaNs(this Quaternion value)
        {
            value.x = value.x.RemoveNaN();
            value.y = value.y.RemoveNaN();
            value.z = value.z.RemoveNaN();

            return value;
        }
    }
}