using CompositionPosts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionPosts {
    internal class Program {
        static void Main(string[] args) {

            // Create posts and commentaries
            Comment c1 = new Comment("Tenha uma boa viagem!");
            Comment c2 = new Comment("Isto é muito legal, cara!");
            Post p1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Viagem à Nova Zelândia", "Estou visitando um país novo e muito interessante!", 12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Boa noite!");
            Comment c4 = new Comment("Que a força esteja com você");
            Post p2 = new Post(DateTime.Parse("28/07/2018 23:14:20"), "Boa noite pessoal", "Vejo vocês amanhã", 5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            // Print the posts
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
