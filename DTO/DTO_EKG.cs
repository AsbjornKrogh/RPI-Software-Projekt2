﻿using System;
using System.Collections.Generic;
using System.Text; 

namespace DTO
{
   public class DTO_EKG
   {
      public short mvEKG { get; set; }
      public DateTime DateTime { get; set; }

      public DTO_EKG(short mvEKG, DateTime dateTime)
      {
         this.mvEKG = mvEKG;
         this.DateTime = dateTime; 
            global::System.Console.WriteLine("Peter was here");
            global::System.Console.WriteLine("SKIFT DET NAVN");
            global::System.Console.WriteLine("Nu burde det navn være skiftet");
      }
   }
}
