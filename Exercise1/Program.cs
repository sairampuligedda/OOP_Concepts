// See https://aka.ms/new-console-template for more information

using Exercise1;

var Post = new Post("SQL Query", "Foreign Key Exception");

void VotePost()
{
    Console.WriteLine("Enter '0' to quit, '1' to upvote and '2' to downvote");

    while (true)
    {
        var key = Console.ReadLine();

        if (key == "1")
            Post.UpVote();
        if (key == "2")
            Post.DownVote();
        if (key == "3")
            break;
        if (key == "4")
            Console.WriteLine(Post.GetVotes()); 
    }
}

VotePost();

//var stopWatch = new StopWatch();
// void RunStopWatch() 
//{
//    Console.WriteLine("Enter '0' to quit, '1' to start and '2' to stop smartwatch");

//    while (true) {
//        var key = Console.ReadLine();
//        if(key == "0")
//            break;

//        if(string.IsNullOrEmpty(key))
//            Console.WriteLine("enter proper value");

//        else {
//            try {
//                if (key.Equals("1")) {
//                    stopWatch.StartTimer();
//                    Console.WriteLine("Timer Started!");
//                }
//                else if (key.Equals("2")) { 
//                    var time = stopWatch.StopTimer();
//                    Console.WriteLine("Timer Completed, time elapsed is {0}", time.TotalSeconds);
//                }
//                else
//                    Console.WriteLine("Enter a proper number");
//            }

//            catch (Exception ex) {
//                Console.WriteLine("Exception is: {0}", ex.Message);
//            }   
                
//        }
//    }
//    Console.WriteLine("Stopwatch Deactivated!");
//}
//RunStopWatch();
