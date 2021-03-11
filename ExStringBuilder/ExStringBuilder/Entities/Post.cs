using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExStringBuilder.Entities
{
    class Post
    {
        public  DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();    //Composição

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
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();     //Me traz várias opções para montar um texto.
            sb.AppendLine(Title);       //Adciona um texto e uma quebra de linha no fim do "StringBuilder"
            sb.Append(Likes);           //Ao invés de usar concatenação, uso o StringBuilder e suas funções. 
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH/mm/ss"));
            sb.AppendLine(Content);
            sb.Append("Comments: ");
            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);      //Para cada comentário c na lista Comments, vou imprimi-lo e quebrar uma linha.
            }
            return sb.ToString();

        }
    }
}
