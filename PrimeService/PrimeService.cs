using System;
using System.Linq;

namespace Prime.Services
{
    public partial class PrimeService
    {
        public int hurdleRace(int k, int[] height)
        {
            var requiredJumpLevel = height.Max();
            var gap = requiredJumpLevel - k;
            if (gap > 0) return gap;
            return 0;
        }
    }
}