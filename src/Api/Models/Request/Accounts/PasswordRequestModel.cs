﻿using System.ComponentModel.DataAnnotations;

namespace Bit.Api.Models
{
    public class PasswordRequestModel
    {
        [Required]
        [StringLength(300)]
        public string MasterPasswordHash { get; set; }
        [Required]
        [StringLength(300)]
        public string NewMasterPasswordHash { get; set; }
        [Required]
        public CipherRequestModel[] Ciphers { get; set; }
    }
}
