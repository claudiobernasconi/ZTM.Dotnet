namespace MVCDependencyInjection.Services;

public class LocalizedText : ILocalizedText
{
    public string GetPageTitle(string language)
    {
        switch (language)
        {
            case "en":
                return "Welcome";
            case "de":
                return "Willkommen";
        }

        throw new NotSupportedException($"The language '{language}' is not supported.");
    }
}
