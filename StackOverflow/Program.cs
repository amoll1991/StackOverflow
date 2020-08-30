using System;

namespace StackOverflow
{
    class Post
    {
        private int voteCount=0;

        public Post(string title, string description, DateTime dt)
        {
            Console.WriteLine(title);
            Console.WriteLine(description);
            Console.WriteLine(dt);
        }
        public void UpVote()
        {
            voteCount++;
        }

        public void DownVote()
        {
            voteCount--;
        }

        static void Main(string[] args)
        {
            int choice;
            Post p1 = new Post("What is Object", "Object is instance of class", DateTime.Now);
            Console.WriteLine("Hello World!");
            Console.WriteLine("1.Up Vote");
            Console.WriteLine("2.Down Vote");
            Console.WriteLine("3.Display Vote Count");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Enter choice:");
            do
            {
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        p1.UpVote();
                        break;
                    case 2:
                        p1.DownVote();
                        break;
                    case 3:
                        Console.WriteLine("Vote Count:"+p1.voteCount);
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice... Please try again");
                        break;
                }
            } while (true);
        }
    }
}
