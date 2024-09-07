﻿using System.ComponentModel.DataAnnotations;

namespace Aklat.ViewModel
{
    public class LoginViewModel
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
