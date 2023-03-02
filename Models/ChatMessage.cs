﻿namespace AdvancedProjectMVC.Models
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string ApplicationUserId { get; set; }
        public string Content { get; set; }
        public DateTime DatePosted { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public Course Course { get; set; }
    }
}