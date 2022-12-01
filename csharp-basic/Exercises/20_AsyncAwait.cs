using System;
using System.Threading.Tasks;

namespace Exercises
{
    public class AsyncAwait
    {
        private readonly John John = new John();
        private readonly Clair Clair = new Clair();
        private readonly Mother Mother = new Mother();

        public int TotalStarsOnRefrigerator => John.StarsOnRefrigerator + Clair.StarsOnRefrigerator;

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
            var johnFinished =  await John.CleanRoom();
            var clairFinished = await Clair.TakeOutGarbage();

            Mother.PutUpStars(johnFinished, clairFinished);
        }
    }

    public class Mother
    {
        public void PutUpStars(John john, Clair clair)
        {
            john.StarsOnRefrigerator++;
            clair.StarsOnRefrigerator++;
        }
    }

    public class John
    {
        public int StarsOnRefrigerator { get; set; }

        public async Task<John> CleanRoom()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            return this;
        }
    }
    public class Clair
    {
        public int StarsOnRefrigerator { get; set; }
        public async Task<Clair> TakeOutGarbage()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            return this;
        }
    }
}
