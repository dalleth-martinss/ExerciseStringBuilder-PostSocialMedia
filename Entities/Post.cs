using System;
using System.Collections.Generic;
using System.Text;


namespace ExerciceStringBuilderPostSocialMedia.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public  int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>(); // garantir que vai iniciar uma lista vazia do tipo Comment
    
        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);

        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        // serve para sobreescrever e deixar o output legivel e formatado 
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/mm/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
        foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }

    }
} 

//STRING BUILDER => é responsavel pela montagem do formato do output em string conforme eu quero
// de uma forma super eficiente, depois que tiver pronto pego o resuldo disso e passo para strig
//AppendLine() => adiciona texto no fim do string builder e coloca quebra de linha 



// Quando temos um diagrama com " relação tem muitos"  ---> * (seta com asterisco)
// fazemos os metodos Adicionar e remover. 