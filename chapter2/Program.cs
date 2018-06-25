using System;
using System.Threading;
using System.Threading.Tasks;

namespace chapter2
{
    class Program
    {
		double maxTime;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Doubler(2, Result);
			Doubler(3, Result);
		    Doubler(10, Result);
			Console.ReadLine();
        }
    
	
	private static void Doubler(int v, Action<string, int> callback) {
		Console.WriteLine("Worker thread in Doubler " + Thread.CurrentThread.ManagedThreadId);
		//var waitTime = Math.Floor(Math()*(maxTime+1));
		if (v%2 != 0) {
			Task.Run(() => callback("Odd input", 0));			
		}
		else {
		    Task.Run(() => callback(null, v * 2));	
		}
	}

	private static void Result(string err, int results){
		Console.WriteLine("Worker thread in handleResults " + Thread.CurrentThread.ManagedThreadId);
		if(err != null){
		   Console.WriteLine("Error: " + err);
		}
		else {
		   Console.WriteLine("The results are: " + results);
		}
	}

}
	
	
}


