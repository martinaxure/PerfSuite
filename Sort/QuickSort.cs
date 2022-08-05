namespace PerfSuite.Sort;
public static class QuickSort {

    public static void SortArray(int[] array) => SortArray(array, 0, array.Length - 1);
    private static void SortArray(int[] array, int leftIndex, int rightIndex) {
        var (i, j) = (leftIndex, rightIndex);
        // var j = rightIndex;
        var pivot = array[leftIndex];
        while (i <= j) {
            while (array[i] < pivot) i++;
            while (array[j] > pivot) j--;
            if (i <= j) {
                (array[i], array[j]) = (array[j], array[i]);
                i++;
                j--;
            }
        }
        if (leftIndex < j) SortArray(array, leftIndex, j);
        if (i < rightIndex) SortArray(array, i, rightIndex);
    }

    public static Task SortArrayAsync(int[] array) {
        var val = SortArrayAsync(array, 0, array.Length - 1);
        return val;
    }
    private static async Task SortArrayAsync(int[] array, int leftIndex, int rightIndex) {
        var (i, j) = (leftIndex, rightIndex);
        // var j = rightIndex;
        var pivot = array[leftIndex];
        while (i <= j) {
            while (array[i] < pivot) i++;
            while (array[j] > pivot) j--;
            if (i <= j) {
                (array[i], array[j]) = (array[j], array[i]);
                i++;
                j--;
            }
        }
        if (leftIndex < j) await SortArrayAsync(array, leftIndex, j);
        if (i < rightIndex) await SortArrayAsync(array, i, rightIndex);
    }

    public static ValueTask SortArrayAsyncValue(int[] array) {
        var val = SortArrayAsyncValue(array, 0, array.Length - 1);
        return val;
    }
    private static async ValueTask SortArrayAsyncValue(int[] array, int leftIndex, int rightIndex) {
        var (i, j) = (leftIndex, rightIndex);
        // var j = rightIndex;
        var pivot = array[leftIndex];
        while (i <= j) {
            while (array[i] < pivot) i++;
            while (array[j] > pivot) j--;
            if (i <= j) {
                (array[i], array[j]) = (array[j], array[i]);
                i++;
                j--;
            }
        }
        if (leftIndex < j) await SortArrayAsyncValue(array, leftIndex, j);
        if (i < rightIndex) await SortArrayAsyncValue(array, i, rightIndex);
    }

    public static Task<int> SortArrayAsyncT(int[] array) {
        var val = SortArrayAsyncT(array, 0, array.Length - 1);
        return val;
    }
    private static async Task<int> SortArrayAsyncT(int[] array, int leftIndex, int rightIndex) {
        var (i, j) = (leftIndex, rightIndex);
        // var j = rightIndex;
        var pivot = array[leftIndex];
        while (i <= j) {
            while (array[i] < pivot) i++;
            while (array[j] > pivot) j--;
            if (i <= j) {
                (array[i], array[j]) = (array[j], array[i]);
                i++;
                j--;
            }
        }
        if (leftIndex < j) await SortArrayAsyncT(array, leftIndex, j);
        if (i < rightIndex) await SortArrayAsyncT(array, i, rightIndex);
        return 0;
    }

    public static ValueTask<int> SortArrayAsyncValueT(int[] array) {
        var val = SortArrayAsyncValueT(array, 0, array.Length - 1);
        return val;
    }
    private static async ValueTask<int> SortArrayAsyncValueT(int[] array, int leftIndex, int rightIndex) {
        var (i, j) = (leftIndex, rightIndex);
        // var j = rightIndex;
        var pivot = array[leftIndex];
        while (i <= j) {
            while (array[i] < pivot) i++;
            while (array[j] > pivot) j--;
            if (i <= j) {
                (array[i], array[j]) = (array[j], array[i]);
                i++;
                j--;
            }
        }
        if (leftIndex < j) await SortArrayAsyncValueT(array, leftIndex, j);
        if (i < rightIndex) await SortArrayAsyncValueT(array, i, rightIndex);
        return 0;
    }
}
