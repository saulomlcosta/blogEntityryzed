using Blog.Data;
using Blog.Models;

using var context = new BlogDataContext();

context.Users.Add(new User
{
    Bio = "Um Desenvolvedor",
    Email = "saulo@gmail.com",
    Image = "http://teste.com/images/",
    Name = "Saulo Costa",
    PasswordHash = "password",
    Slug = "saulo-costa"
});
context.SaveChanges();

var user = context.Users.FirstOrDefault();
var post = new Post
{
    Author = user,
    Body = "Meu Post",
    Category = new Category
    {
        Name = "Frontend",
        Slug = "frontend"
    },
    CreateDate = System.DateTime.Now,
    Slug = "meu-post",
    Summary = "Neste artigo vamos ...",
    Title = "Meu artigo",
};
context.Posts.Add(post);
context.SaveChanges();