﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Services.Localization
{
   public interface ITranslationService
    {

        public void Translate( string  translationStrings, string key);
    }
}
