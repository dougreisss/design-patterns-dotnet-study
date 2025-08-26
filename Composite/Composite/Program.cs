using Composite;

DiretorioComposite tree = new("C:\\");
PastaLeaf pasta1 = new("System32\\");
PastaLeaf pasta2 = new("DLLs\\");
DiretorioComposite pasta3 = new("Documents\\");

PastaLeaf pasta4 = new("Music\\");
PastaLeaf pasta5 = new("Picture\\");
PastaLeaf pasta6 = new("Temp\\");


tree.Add(pasta1);
tree.Add(pasta2);
tree.Add(pasta3);

tree.Mostrar();

pasta3.Add(pasta4);
pasta3.Add(pasta5);
pasta3.Add(pasta6);

pasta3.Mostrar();
