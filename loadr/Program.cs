var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("http://20.101.201.152");

const int NUM_TASKS = 10000;

var tasks = new Task[NUM_TASKS];
for (int i = 0; i < NUM_TASKS; i++)
{
    

    var locali = i;
    Task t = Task.Run(async () => {        
        await httpClient.GetAsync("/");
        if (locali % 100 == 0) 
            Console.WriteLine(locali);
    });

    tasks[i] = t;
}

await Task.WhenAll(tasks);

Console.WriteLine("done"); 


