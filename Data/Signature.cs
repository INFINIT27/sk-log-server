﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SharkValleyServer.Data
{
    public class Signature
    {
        [Key]
        public int Id { get; set; }
        public string? FullName { get; set; }

        public int? PatrolLogId { get; set; }

        [JsonIgnore]
        public PatrolLog? PatrolLog { get; set; }
    }
}