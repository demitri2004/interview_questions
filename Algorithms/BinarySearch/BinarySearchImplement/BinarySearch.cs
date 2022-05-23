using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchImplement
{
    public class BinarySearch
    {
        public bool recursive(int[] arr, int el)
        {
            return recursive(arr, el, 0, arr.Length - 1);
        }

        public bool recursive(int[] arr, int el, int left, int right)
        {
            bool response = false;

            //if(left < right)
            //{
                int mid = (right + left) / 2;
                if (arr[mid] == el)
                {
                    return true;
                }
                else
                {
                    if(arr[mid] > el)
                    {
                        if (left != mid)
                            return recursive(arr, el, left, mid-1);
                        else
                            return response;
                    }
                    else
                    {
                        if (left != mid)
                            return recursive(arr, el, mid+1, right);
                        else
                            return response;                        
                    }
                }
            //}
            //else
            //{
            //    return response;
            //}            
        }

        public bool iterative(int[] arr, int el)
        {
            bool response = false;

            int left = 0;
            int right = arr.Length - 1;
            int mid;
            
            while(right >= left)
            {
                mid = left + ((right - left) / 2);
                if(arr[mid] == el)
                {
                    return true;
                }

                if(arr[mid] > el)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return response;
        }
    }
}
