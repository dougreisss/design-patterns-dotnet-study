namespace Singleton.Model;

public class ConfigManager
{
    private static ConfigManager _instance;
    private Dictionary<string, string> _configs;

    private ConfigManager() 
    {
        _configs = new Dictionary<string, string>();
    }

    public static ConfigManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new ConfigManager();
        }

        return _instance;
    }

    public void Set(string key, string value) 
    {
        _configs[key] = value;
    }

    public string Get(string key)
    {
        return _configs.ContainsKey(key) ? _configs[key] : null;
    }
}
