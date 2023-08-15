int Balance = 100;

var t1 = Task.Factory.StartNew(() =>
{
    Parallel.For(0, 10000, _ => Interlocked.Add(ref Balance, 100));

});
var t2 = Task.Factory.StartNew(() =>
{
    Parallel.For(0, 10000, _ => Interlocked.Add(ref Balance, -100));
});
Task.WaitAll(t1, t2);
Console.WriteLine($"Balance is:{Balance}");
