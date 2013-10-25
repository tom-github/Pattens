using System;
using System.Collections.Generic;
using System.Reflection;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            UntranslatedModel untranslatedModel = new UntranslatedModel { Id = 0, Name = "Zero" };

            Console.WriteLine("Objeto a traduzir:" + untranslatedModel.GetType().Name);

            foreach (PropertyInfo propertie in untranslatedModel.GetType().GetProperties())
            {
                Console.WriteLine(propertie + ": " + propertie.GetValue(untranslatedModel, null));
            }

            TranslatedModel translatedModel = untranslatedModel.TranslatedModel();


            Console.WriteLine("Objeto traduzido:" + translatedModel.GetType().Name);

            foreach (PropertyInfo propertie in translatedModel.GetType().GetProperties())
            {
                Console.WriteLine(propertie + ": " + propertie.GetValue(translatedModel, null));
            }

            List<UntranslatedModel> listUntranslatedModel = new List<UntranslatedModel>
                {
                    new UntranslatedModel {Id = 1, Name = "one"},
                    new UntranslatedModel {Id = 2, Name = "two"},
                    new UntranslatedModel {Id = 3, Name = "three"}
                };

            //Tranalate List
            List<TranslatedModel> listTranslatedModel = listUntranslatedModel.ListTranslatedModel();
        }
    }
}
