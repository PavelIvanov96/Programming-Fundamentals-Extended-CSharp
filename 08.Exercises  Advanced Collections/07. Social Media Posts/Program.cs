using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Social_Media_Posts
{
    class Program
    {

         static Dictionary<string, Dictionary<string, string>> dicComment = new Dictionary<string, Dictionary<string, string>>();
       
         static Dictionary<string, int> dicLikes = new Dictionary<string, int>();
       
         static Dictionary<string, int> dicDisLikes = new Dictionary<string, int>();

        static void Main(string[] args)
        {
           

            string input = Console.ReadLine();

            while (input != "drop the media")
            {
                string[] inputTokens = input.Split(' ');

                var command = inputTokens[0];
                var postName = inputTokens[1];

                switch (command)
                {
                    case "post":
                        {
                            CreatePost(postName);
                            break;
                        }
                    case "like":
                        {
                            LikePost(postName);
                            break;
                        }
                    case "dislike":
                        {
                            DislikePost(postName);
                            break;
                        }
                    case "comment":
                        {
                            string commentatorName = inputTokens[2];
                         string content =  string.Join(" ", inputTokens.Skip(3).ToArray());
                            CommentPost(postName, commentatorName, content);
                            break;
                        }
                }

                input = Console.ReadLine();
            }
            foreach (var  item in dicComment)
            {
                var likes = dicLikes[item.Key];
                var dislikes = dicDisLikes[item.Key];
                var commentsData = item.Value;
                Console.WriteLine("Post: {0} | Likes: {1} | Dislikes: {2}",item.Key,likes,dislikes);
                Console.WriteLine("Comments:");
                if (commentsData.Count == 0)
                {
                    Console.WriteLine("None");
                }
                foreach (var comm in commentsData)
                {
                    string comName = comm.Key;
                    string comComent = comm.Value;
                    Console.WriteLine("*  {0}: {1}",comName,comComent);

                }
            }
            
        }

        private static void CommentPost(string postName, string commentatorName, string content)
        {
            dicComment[postName].Add(commentatorName, content);
        }

        private static void DislikePost(string postName)
        {
            dicDisLikes[postName]++;
        }

        private static void LikePost(string postName)
        {
            dicLikes[postName]++;
        }

        private static void CreatePost(string postName)
        {
            dicComment.Add(postName, new Dictionary<string, string>());
            dicLikes.Add(postName, 0);
            dicDisLikes.Add(postName, 0);
        }
    }
}
