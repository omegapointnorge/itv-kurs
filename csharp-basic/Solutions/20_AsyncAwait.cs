namespace Solutions
{
    public class AsyncAwait
    {
        private readonly John _john = new();
        private readonly Clair _clair = new();

        public int TotalStarsOnRefrigerator => _john.StarsOnRefrigerator + _clair.StarsOnRefrigerator;

        /*
        The following method tells Clair and John to go do their duties.
        When they are done they receive a star on the refrigerator.
        As the method is implemented now, it will take over 10 seconds total 
        for both to complete their tasks, because Clair waits for John to finish
        before starting her task.
        Change the method, and make it complete in 5 seconds!
        */

        public async Task TellTheKidsToDoTheirDuties()
        {
            //(Original method)
            //await John.CleanRoom();
            //await Clair.TakeOutGarbage();

            var task1 = _john.CleanRoom();
            var task2 = _clair.TakeOutGarbage();
            await Task.WhenAll(task1, task2);
        }
    }

    public class John
    {
        public int StarsOnRefrigerator { get; set; }

        public async Task CleanRoom()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            StarsOnRefrigerator++;
        }
    }

    public class Clair
    {
        public int StarsOnRefrigerator { get; set; }

        public async Task TakeOutGarbage()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            StarsOnRefrigerator++;
        }
    }
}