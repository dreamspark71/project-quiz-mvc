﻿namespace QuizProjectMvc.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Models;
    using QuizProjectMvc.Common;

    public class Category : BaseModel<int>
    {
        private ICollection<Quiz> quizzes;

        public Category()
        {
            this.quizzes = new HashSet<Quiz>();
        }

        [Required]
        [MinLength(ModelConstraints.NameMinLength)]
        [MaxLength(ModelConstraints.NameMaxLength)]
        public string Name { get; set; }

        [Url]
        [MinLength(ModelConstraints.UrlMinLength)]
        [MaxLength(ModelConstraints.UrlMaxLength)]
        public string AvatarUrl { get; set; }

        public virtual ICollection<Quiz> Quizzes
        {
            get { return this.quizzes; }
            set { this.quizzes = value; }
        }
    }
}