namespace PerfSuite.Sort;

public static class SampleGenerator {
    public static int[] Generate(int size, int? seed = null) {
        var random = seed != null ? new Random(seed.Value) : new Random();
        var val = new int[size];
        for(var i = 0; i < size; i++) val[i] = random.Next();
        return val;
    }
}