using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    public class UntranslatedModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public static class TranslatedModelExtensionMethods
    {
        public static TranslatedModel TranslatedModel(this UntranslatedModel model)
        {
            return new TranslatedModel
                {
                    Id = model.Id,
                    Name = model.Name
                };
        }

        public static List<TranslatedModel> ListTranslatedModel(this List<UntranslatedModel> modelList)
        {
            return modelList == null ? null : modelList.Select(p => p.TranslatedModel()).ToList();
        }
    }
}
