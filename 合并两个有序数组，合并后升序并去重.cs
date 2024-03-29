public class Solution
{
    public double AddTwoSortedArrays(int[] nums1, int[] nums2)
    {   
        // 创建一个新的列表来存储合并后的数组
        List<int> result = new List<int>();
        // 初始化两个指针，分别指向两个数组的开始
        int i = 0, j = 0;
        // 当两个指针都没有到达各自数组的末尾时，进行循环
        while (i < nums1.Length && j < nums2.Length)
        {
            // 如果nums1的当前元素小于nums2的当前元素，将nums1的当前元素加入结果，并将指针i向前移动一位
            if (nums1[i] < nums2[j])
            {
                if (result.Count == 0 || nums1[i] != result[result.Count - 1])
                {
                    result.Add(nums1[i]);
                }

                i++;
            }
            // 如果nums1的当前元素大于nums2的当前元素，将nums2的当前元素加入结果，并将指针j向前移动一位
            else if (nums1[i] > nums2[j])
            {
                if (result.Count == 0 || nums2[j] != result[result.Count - 1])
                {
                    result.Add(nums2[j]);
                }

                j++;
            }
            // 如果nums1和nums2的当前元素相等，将任意一个元素加入结果，并将两个指针都向前移动一位
            else
            {
                if (result.Count == 0 || nums1[i] != result[result.Count - 1])
                {
                    result.Add(nums1[i]);
                }

                i++;
                j++;
            }
        }

        // 如果nums1还有剩余元素，将其加入结果
        while (i < nums1.Length)
        {
            if (result.Count == 0 || nums1[i] != result[result.Count - 1])
            {
                result.Add(nums1[i]);
            }

            i++;
        }

        // 如果nums2还有剩余元素，将其加入结果
        while (j < nums2.Length)
        {
            if (result.Count == 0 || nums2[j] != result[result.Count - 1])
            {
                result.Add(nums2[j]);
            }

            j++;
        }
    }
}