using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Category
    {
        // temporal collection to be initializet with the
        // constructor wich use virtual property for articles
        private ICollection<Article> articles;

        // Create initial constructor to fill some empty
        // article set, to array for new Category to be different from Null!!!
        public Category()
        {
            this.articles = new HashSet<Article>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(20)]
        public string Name { get; set; }

        public virtual ICollection<Article> Articles
        {
            //get { return this.articles; }
            //set { this.articles = value; }

            get; set;
        }
    }
}