using BenchmarkDotNet.Running;
using foreach_vs_parallel;

//var listIteration = new ListIterationPerformance();
//listIteration.Setup();
//listIteration.ForeachPerformance();
var summary = BenchmarkRunner.Run<ListIterationPerformance>();
Console.WriteLine("Hello, World!");

