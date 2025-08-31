using Proxy;

ConfiguracaoProxy configuracaoProxy = new ConfiguracaoProxy();

configuracaoProxy.Inicializar();
configuracaoProxy.SetConfig("key1", "teste1");

Console.WriteLine(configuracaoProxy.GetConfig("key01"));