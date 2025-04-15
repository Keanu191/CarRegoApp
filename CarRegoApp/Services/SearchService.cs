namespace CarRegoApp.Services
{
    /// <summary>
    /// Provides search functionality for registration plates.
    /// </summary>
    public class SearchService
    {
        /// <summary>
        /// Performs a binary search on the registration list.
        /// </summary>
        public static int BinarySearch(List<string> regoList, string target)
        {
            return regoList.BinarySearch(target);
        }

        /// <summary>
        /// Performs a linear search on the registration list.
        /// </summary>
        public static int LinearSearch(List<string> regoList, string target)
        {
            for (int i = 0; i < regoList.Count; i++)
            {
                if (regoList[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}