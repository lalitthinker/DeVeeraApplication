namespace CRM.Core.Domain.GoogleTranslate.Objects.LanguageDetection
{
    public class LanguageDetection
    {
        public string Language { get; set; }
        public bool IsReliable { get; set; }
        public float Confidence { get; set; }
    }
}