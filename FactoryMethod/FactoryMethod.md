# Factory Method – Design Pattern (GoF)

## 📜 Breve História  
O **Factory Method** foi formalmente descrito pelo *Gang of Four* (GoF) no livro *"Design Patterns: Elements of Reusable Object-Oriented Software"* (1994).  
A ideia central já era utilizada antes, mas o GoF consolidou o padrão como uma solução elegante para criar objetos sem acoplar diretamente o código cliente às classes concretas.  
O padrão faz parte do grupo **Criacional** e seu objetivo é delegar a responsabilidade da criação de objetos para subclasses, garantindo maior flexibilidade e extensibilidade no sistema.

---

## 🎯 Quando Utilizar / Qual Problema Soluciona  
Você deve considerar o uso do **Factory Method** quando:  
- Quer **desacoplar** o código cliente das classes concretas que ele instancia.  
- Precisa permitir que subclasses **decidam qual objeto criar**.  
- Deseja facilitar a **extensão** do sistema sem modificar código existente (Princípio *Open/Closed*).  
- Tem uma **família de objetos** relacionados e quer centralizar a lógica de criação.  

**Problema solucionado:**  
Em sistemas que precisam criar objetos complexos ou com variações, instanciar diretamente as classes concretas pode gerar **alto acoplamento** e dificultar manutenção. O **Factory Method** abstrai esse processo, fornecendo um ponto único e polimórfico para criar objetos.

---

## ⚠️ Contras  
Apesar das vantagens, o **Factory Method** também possui desvantagens:  
- **Aumento da complexidade**: Introduz classes e métodos adicionais, o que pode ser excessivo em sistemas simples.  
- **Múltiplas subclasses**: Pode gerar uma hierarquia extensa se houver muitas variações de produtos.  
- **Sobrecarga inicial de implementação**: Para projetos pequenos, o custo de aplicar o padrão pode não compensar.

