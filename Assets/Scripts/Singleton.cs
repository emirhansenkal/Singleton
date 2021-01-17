using System;

public class Singleton
{
    private string text;

    private static Singleton instance = null;
    
    private Singleton()
    {
        text = "Hello World";
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        
        return instance;
    }

    public string GetText()
    {
        return text;
    }
}


