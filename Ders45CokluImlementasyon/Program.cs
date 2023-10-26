using Ders45CokluImlementasyon;

IWorker[] workers = new IWorker[3]
{
    new Manager(),
    new Worker(),
    new Robot()
};
foreach (var worker in workers)
{
    worker.Work();
}


IEat[] eats = new IEat[2]
{
    new Worker(),
    new Manager()
  
};
foreach (var eat in eats)
{
    eat.Eat();
}