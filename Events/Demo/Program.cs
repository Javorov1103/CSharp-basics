using System;
using System.Collections.Generic;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IPostService postService = new PostService();
            IPostService postService2 = new NewPostService();

            List<IPostService> postServices = new List<IPostService>();

            postServices.Add(postService);
            postServices.Add(postService2);
        }
    }

    public interface IPostService
    {
        void CreatePost();
        void AddPost();
    }

    public class PostService : IPostService
    {
        public void CustomMethod()
        {

        }
        public void CreatePost()
        {

        }

        public void AddPost()
        {

        }
    }

    public class NewPostService : IPostService
    {
        public void AddPost()
        {
            
        }

        public void CreatePost()
        {
            
        }
    }


}
