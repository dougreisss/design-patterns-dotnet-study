using AbstractFactory.Interfaces;
using AbstractFactory.Mac;
using AbstractFactory.Windows;

IUIFactory factory;

factory = new WindowsUIFactory();
factory.CriarBotao().Render();
factory.CriarCheckbox().Marcar();

factory = new MacUIFactory();
factory.CriarBotao().Render();
factory.CriarCheckbox().Marcar();