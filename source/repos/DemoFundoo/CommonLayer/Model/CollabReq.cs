﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CommonLayer.Model
{
    public class CollabReq
    {
        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(320, ErrorMessage = "Email address should not exceed 320 characters.")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [JsonIgnore]
        public long UserId { get; set; }
        public long NoteId { get; set; }
    }
}
