﻿using Enterprisev2.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Enterprisev2.Enums;

namespace Enterprisev2.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "You need to add Title ...")]
        [StringLength(255)]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public PostStatus Status { get; set; } = PostStatus.Post;
        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
        public string UserId { get; set; }
        public User User { get; set; }
        public byte[] ImageData { get; set; }
        public byte[] Like { get; set; }
        public byte[] DisLike { get; set; }
        public List<Comment> Comments { get; set; }
        public int Active { get; set; }
    }
}
