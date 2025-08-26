# Decorator – Design Pattern (GoF)

## 📜 Breve História  
O **Decorator** foi descrito pelo *Gang of Four* (GoF) no livro *"Design Patterns: Elements of Reusable Object-Oriented Software"* (1994).  
Ele pertence ao grupo **Estrutural** e surgiu como solução para **adicionar responsabilidades a objetos em tempo de execução**, sem precisar modificar suas classes originais.  
Esse padrão é inspirado no conceito de **embrulhar (decorar) um objeto** para estender seu comportamento dinamicamente.

---

## 🎯 Quando Utilizar / Qual Problema Soluciona  
Você deve considerar o uso do **Decorator** quando:  
- Precisa **adicionar comportamentos ou responsabilidades a objetos em tempo de execução**.  
- Deseja evitar o uso excessivo de herança para estender funcionalidades.  
- Quer montar objetos de forma **flexível e combinável**, aplicando múltiplos decoradores conforme a necessidade.  
- O sistema deve permitir que funcionalidades sejam **empilhadas dinamicamente**.  

**Problema solucionado:**  
Sem o Decorator, geralmente usamos **herança** para adicionar funcionalidades. Isso pode gerar uma explosão de subclasses para cada combinação de comportamentos.  
O **Decorator** resolve isso permitindo **composição dinâmica**, onde objetos podem ser embrulhados em outros para ganhar novos comportamentos.

---

## ⚠️ Contras  
Apesar das vantagens, o **Decorator** também apresenta desvantagens:  
- **Complexidade estrutural**: Muitos objetos decorados podem deixar o sistema mais difícil de entender e depurar.  
- **Ordem dos decoradores importa**: A forma como os objetos são embrulhados pode impactar diretamente no resultado final.  
- **Sobrecarga de código**: Pode ser necessário criar muitas classes pequenas (decoradores) para diferentes responsabilidades.  
