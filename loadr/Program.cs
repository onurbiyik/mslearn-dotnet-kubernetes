var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("http://20.101.201.152");

const int NUM_TASKS = 100;
int processed = 0;

var tasks = new Task[NUM_TASKS];
for (int i = 0; i < NUM_TASKS; i++)
{
    Task t = Task.Run(async () => {        
        await httpClient.GetAsync("/");
        
        Interlocked.Increment(ref processed);
        if (processed % 10 == 0) 
            Console.Write("{0,3}\b\b\b", processed);
    });

    tasks[i] = t;
}

await Task.WhenAll(tasks);

Console.WriteLine("done"); 


