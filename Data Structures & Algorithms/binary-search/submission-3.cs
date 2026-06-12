public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right) {
            // Tính chỉ số ở giữa để tránh tràn số (overflow)
            int mid = left + (right - left) / 2;

            // Nếu tìm thấy target, trả về chỉ số (index) của nó
            if (nums[mid] == target) {
                return mid;
            }
            // Nếu target nhỏ hơn phần tử ở giữa, thu hẹp phạm vi sang nửa bên trái
            else if (target < nums[mid]) {
                right = mid - 1;
            }
            // Nếu target lớn hơn phần tử ở giữa, thu hẹp phạm vi sang nửa bên phải
            else {
                left = mid + 1;
            }
        }

        // Trả về -1 nếu không tìm thấy target trong mảng
        return -1;
    }
}