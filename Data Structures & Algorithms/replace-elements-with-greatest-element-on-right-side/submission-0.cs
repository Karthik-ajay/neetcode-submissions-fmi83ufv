public class Solution {
    public int[] ReplaceElements(int[] arr) {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.MinValue;
            for (int j = i + 1; j < arr.Length; j++)
                arr[i] = arr[j] > arr[i] ? arr[j] : arr[i];
        }
        arr[arr.Length - 1] = -1;
        return arr;
    }
}