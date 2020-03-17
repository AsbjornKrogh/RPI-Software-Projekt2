using System;
using System.Collections.Generic;
using System.Windows; 
using RaspberryPiCore.i2cdotnet;
using RaspberryPiCore.ADC;
using RaspberryPiCore.TWIST;
using RaspberryPiCore.LCD;
using DTO;
using LogicLayer;
using DataLayer;
using System.Threading;


namespace PresentationsLayer
{
   class Program
   {
      int puls = 0;
      int Rtak_old = 0;
      int Rtak_new = 0;
      double sample;
      double diff;
      private static double threshold = 2.1;
      private static bool belowThreshold = true;

      private static List<double> RRList = new List<double>();

      private static ADC1015 ADC = new ADC1015();
      private static SerLCD LCD = new SerLCD();
      private static TWIST Knap = new TWIST();

      static void Main(string[] args)
      {

         int puls=0;
         int periode = Convert.ToInt32(40) * Convert.ToInt32(10);

         for (int i = 0; i < periode; i++)
         {
            RRList.Add((ADC.readADC_SingleEnded(0) / 2048.0) * 6.144);

            Thread.Sleep(1000 / (Convert.ToInt32(40)) - 4);

            if (RRList[i] > threshold && belowThreshold == true)
            {
               puls++;
            }

            if (RRList[i] < threshold)
            {
               belowThreshold = true;
            }

            else
            {
               belowThreshold = false;
            }
         }
      }
   }
}
