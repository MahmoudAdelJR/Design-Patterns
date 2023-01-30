namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = Enumerable.Range(0, 15);
            Parallel.ForEach(range, i =>
            {
                var voteMachine = VoteMachine.GetVoteMachine;
                voteMachine.RegisterVote();
            });
            Console.WriteLine("Total Votes is --> "+VoteMachine.GetVoteMachine.TotalVotes);
        }
    }
}
/// <Credits>
/// credits reserved for https://www.tutorialsteacher.com/csharp/singleton
/// <Credits>