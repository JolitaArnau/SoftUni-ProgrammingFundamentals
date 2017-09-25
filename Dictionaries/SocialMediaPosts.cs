namespace SocialMediaPosts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SocialMediaPosts
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var posts = new Dictionary<string, Dictionary<string, List<string>>>();



            while (!line.Equals("drop the media"))
            {
                var commandsAndPosts = line
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                var command = commandsAndPosts[0];

                var postName = commandsAndPosts[1];

                switch (command)
                {
                    case "post":
                        //initialize dictionary 
                        if (!posts.ContainsKey(postName))
                        {
                            posts[postName] = new Dictionary<string, List<string>>();
                        }

                        break;
                    case "like":
                        //adding likes
                        if (!posts[postName].ContainsKey("Like"))
                        {
                            posts[postName]["Like"] = new List<string>();
                        }

                        posts[postName]["Like"].Add(command);
           
                        break;
                    case "dislike":
                        //adding dislikes
                        if (!posts[postName].ContainsKey("Dislike"))
                        {
                            posts[postName]["Dislike"] = new List<string>();
                        }

                        posts[postName]["Dislike"].Add(command);

                        break;
                    case "comment":
                        //proccessing comments
                        var writer = commandsAndPosts[2];
                        int length = command.Length + postName.Length + writer.Length + 3;
                        var comment = line.Substring(length);

                        if (!posts[postName].ContainsKey(writer))
                        {
                            posts[postName][writer] = new List<string>();
                        }

                        posts[postName][writer].Add(comment);

                        break;
                }

                line = Console.ReadLine();
            }

            if (line.Equals("drop the media"))
            {
                foreach (var post in posts)
                {
                    var likes = 0;
                    var dislikes = 0;
                    var commentContent = post.Value;

                    foreach (var reaction in post.Value)
                    {
                        if (reaction.Key.Equals("Like"))
                        {
                            likes = reaction.Value.Count;
                        }

                        if (reaction.Key.Equals("Dislike"))
                        {
                            dislikes = reaction.Value.Count;
                        }
                    }

                    Console.WriteLine($"Post: {post.Key} | Likes: {likes} | Dislikes: {dislikes}");

                    Console.WriteLine("Comments:");

                    bool commentsPosted = false;

                    foreach (var comment in commentContent)
                    {
                        if (!comment.Key.Equals("Like") && !comment.Key.Equals("Dislike"))
                        {
                            foreach (var item in comment.Value)
                            {
                                Console.WriteLine($"*  {comment.Key}: {item}");
                            }
                            commentsPosted = true;
                        }

                        if (commentsPosted == false)
                        {
                            Console.WriteLine("None");
                            break;
                        }

                        //commentsPosted = true;
                    }

                }
            }

            Console.ReadKey();
        }
    }
}
