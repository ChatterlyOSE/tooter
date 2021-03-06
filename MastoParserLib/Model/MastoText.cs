﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastoParserLib.Model
{
    public class MastoText : MastoContent
    {
        public bool IsParagraph { get; set; }

        public MastoText(string content, bool isParagraph = false): base(content, MastoContentType.Text)
        {
            IsParagraph = isParagraph;   
        }
    }
}
