namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very very long blog post blablablalblallbal";
            var shortenedPost = post.Shorten(5);
            Console.WriteLine(shortenedPost);
        }
    }
}