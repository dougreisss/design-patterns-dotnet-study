using Singleton.Model;

ConfigManager config1 = ConfigManager.GetInstance();
config1.Set("Ambiente", "Produção");

ConfigManager config2 = ConfigManager.GetInstance();
Console.WriteLine(config1.Get("Ambiente"));

Console.WriteLine(object.ReferenceEquals(config1, config2)); // True
