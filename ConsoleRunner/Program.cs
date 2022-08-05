using System;
using System.Diagnostics;
using PerfSuite.Sort;

namespace PerfSuite.ConsoleRunner;
public static class Program {
    public static async Task Main(string[] args) {
        Console.WriteLine("Hello");
        var vals = SampleGenerator.Generate(10000);
        QuickSort.SortArray(vals);

        await RunTest("Sync", vals => {
            QuickSort.SortArray(vals);
            return Task.CompletedTask;
        });
        await RunTest("Sync", vals => {
            QuickSort.SortArray(vals);
            return Task.CompletedTask;
        });
        await RunTest("Async (Task)", QuickSort.SortArrayAsync);
        await RunTest("Async (Task<T>)", QuickSort.SortArrayAsyncT);
        await RunTest("Async (ValueTask)", async vals => {
            await QuickSort.SortArrayAsyncValue(vals);
        });
        await RunTest("Async (ValueTask<T>)", async vals => {
            await QuickSort.SortArrayAsyncValueT(vals);
        });
    }

    private static async Task RunTest(string testName, Func<int[], Task> action) {
        var vals = SampleGenerator.Generate(1000000, 100);
        var sw = new Stopwatch();
        sw.Start();
        await action(vals);
        sw.Stop();
        Console.WriteLine($"{testName} run took {sw.ElapsedMilliseconds}ms");
    }

    // private static async void RunTest(string testName, Action<int[]> action) {
    //     var vals = SampleGenerator.Generate(1000000, 100);
    //     var sw = new Stopwatch();
    //     sw.Start();
    //     await QuickSort.SortArrayAsyncValueT(vals);
    //     sw.Stop();
    //     Console.WriteLine($"{testName} run took {sw.ElapsedMilliseconds}ms");
    // }
}