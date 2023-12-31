﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App.Application.Model
{
    public class TokenModel
    {
        public string refresh_token;
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public int ext_expires_in { get; set; }
        public string access_token { get; set; }
        public string id_token { get; set; }
    }
}
