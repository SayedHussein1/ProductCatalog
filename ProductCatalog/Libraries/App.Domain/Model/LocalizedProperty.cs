﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Model
{
    public class LocalizedProperty
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public int LanguageId { get; set; }
        public string LocaleKeyGroup { get; set; }
        public string LocaleKey { get; set; }
        public string LocaleValue { get; set; }
    }
}
