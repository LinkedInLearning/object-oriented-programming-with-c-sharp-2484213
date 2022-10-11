namespace OOPAdventure;

public static class Text
{

    private static Language _language;

    public static Language Language
    {

        get
        {

            if (_language == null)
                throw new Exception("No language loaded.");

            return _language;

        }

    }

    public static void LoadLanguage(Language language)
    {
        _language = language;
    }


}