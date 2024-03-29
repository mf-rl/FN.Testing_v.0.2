﻿using System.Collections.Generic;

namespace FN.Testing.Common.WebCore
{
    public class ValidationUploadModel
    {
        public string Field { get; set; }
        public string Key { get; set; }
        public string FailureType { set; get; }
        public ICollection<string> Args { get; } = new List<string>();
    }
}
