using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_enrollment_system.model
{
    internal class Utility
    {
        /// <summary>
        /// Uses while loop to increment the index of the input array using i. While the target is 
        /// not found and while within the array length the loop will continue.
        /// Then if the target value returns true when using the compareTo method then 
        /// found is set to true and the loop is broken, else i is incremented by 1.
        /// then if i is in the array length it returns i, being the index of the target,
        /// else it returns -1
        /// 
        /// pseudocode
        /// i = 0
        /// found = false
        /// while found = false and i (<) array length
        /// {
        ///     if target compares to current array index 
        ///         found = true
        ///     end if
        ///     else
        ///         i++
        ///     end else
        /// end while
        /// 
        /// if i (<) array length
        ///     return i
        /// end if
        /// else
        ///     return -1
        /// end else
        /// 
        /// </summary>
        /// <typeparam Name="T"></typeparam>
        /// <param Name="array"></param>
        /// <param Name="target"></param>
        /// <returns>
        /// returns index of target value if found and -1 if it is not found.
        /// </returns>
        public static int LinearSearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            int i = 0;
            bool found = false;
            while (!found && i < array.Length)
            {
                if (target.CompareTo(array[i]) == 0)
                    found = true;
                else
                    i++;
            }
            if (i < array.Length)
                return i;
            else
                return -1;
        }
        /// <summary>
        /// binaray search assigns the middle value of the sorted array to mid in a dowhile with
        /// an if the middle compares to the target, it returns the current mid value; an if the
        /// target is greater than the mid, it sets the min to the mid+1; and else it sets the
        /// max to mid-1. the continues while min is less than or equal to max, where it will 
        /// then return -1 to show the target was not found.
        /// 
        /// pseudocode
        /// min =0
        /// max = array length
        /// 
        /// do
        ///     mid = (min+max) /2
        ///     if target compares to mid
        ///         return mid
        ///     if target is greater than mid
        ///         min = mid +1
        ///     else
        ///         max = mid -1
        /// while min <= mid
        /// return -1
        /// 
        /// </summary>
        /// <typeparam Name="T"></typeparam>
        /// <param Name="array"></param>
        /// <param Name="target"></param>
        /// <returns></returns>
        public static int BinarySearch<T>(T[] array, T target) where T : IComparable<T>
        {
            int min = 0;
            int max = array.Length - 1;
            int mid;
            do
            {
                //assign mid to middle number
                mid = (min + max) / 2;
                //if found
                if (target.CompareTo(array[mid]) == 0)
                    return mid;
                //if search target is higher than mid
                if (target.CompareTo(array[mid]) > 0)
                    min = mid + 1;
                //if search target is lower than mid
                else
                    max = mid - 1;
                //while min and max are lower and higher
            } while (min <= max);

            //not found
            return -1;
        }

    }
}
