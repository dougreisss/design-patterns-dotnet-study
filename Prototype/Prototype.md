# Prototype – Design Pattern (GoF)

## 📜 Breve História  
O **Prototype** foi descrito pelo *Gang of Four* (GoF) no livro *"Design Patterns: Elements of Reusable Object-Oriented Software"* (1994).  
A motivação para esse padrão veio da necessidade de **criar novos objetos copiando instâncias existentes**, ao invés de instanciá-los diretamente.  
Ele pertence ao grupo **Criacional** e promove a clonagem de objetos mantendo sua estrutura e estado, podendo ainda modificar partes conforme necessário.

---

## 🎯 Quando Utilizar / Qual Problema Soluciona  
Você deve considerar o uso do **Prototype** quando:  
- Criar um objeto do zero é **custoso ou complexo**, e é mais eficiente copiar um existente.  
- Precisa **evitar a criação direta** de instâncias para reduzir acoplamento.  
- Deseja criar objetos com **valores padrão** já definidos.  
- O número de combinações possíveis de configuração de um objeto é muito grande.  

**Problema solucionado:**  
Quando um sistema precisa criar muitos objetos semelhantes e a construção tradicional se torna repetitiva ou cara, o **Prototype** permite criar novas instâncias clonando objetos existentes, reduzindo código duplicado e esforço de configuração.

---

## ⚠️ Contras  
Apesar das vantagens, o **Prototype** apresenta desvantagens:  
- **Complexidade na clonagem profunda** (*deep copy*): Pode ser difícil de implementar se o objeto tiver muitas referências para outros objetos.  
- **Cópia acidental de referências indesejadas**: Sem o devido cuidado, alterações no clone podem afetar o original (em cópias rasas – *shallow copy*).  
- **Não elimina totalmente o acoplamento**: Ainda é preciso conhecer a interface do objeto a ser clonado.

