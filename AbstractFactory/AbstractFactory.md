# Abstract Factory – Design Pattern (GoF)

## 📜 Breve História  
O **Abstract Factory** foi descrito pelo *Gang of Four* (GoF) no livro *"Design Patterns: Elements of Reusable Object-Oriented Software"* (1994).  
Esse padrão surgiu para resolver problemas de criação de famílias de objetos relacionados, mantendo a aplicação desacoplada das implementações concretas.  
Ele pertence ao grupo **Criacional** e pode ser visto como uma evolução do **Factory Method**, fornecendo uma interface para criar **conjuntos inteiros** de objetos compatíveis.

---

## 🎯 Quando Utilizar / Qual Problema Soluciona  
Você deve considerar o uso do **Abstract Factory** quando:  
- Precisa criar **famílias de objetos relacionados** que devem trabalhar juntos.  
- Quer garantir que objetos criados sejam **compatíveis** entre si.  
- Deseja **isolar a lógica de criação** de objetos para facilitar manutenção e extensibilidade.  
- Precisa trocar facilmente a **família de produtos** utilizada na aplicação (por exemplo, temas gráficos, conexões a bancos diferentes, drivers de dispositivos).

**Problema solucionado:**  
Quando um sistema precisa trabalhar com múltiplos produtos que pertencem a diferentes famílias, instanciar diretamente as classes concretas pode gerar **alto acoplamento** e risco de incompatibilidade. O **Abstract Factory** cria um **ponto único de criação** para todos os objetos da mesma família, mantendo consistência e flexibilidade.

---

## ⚠️ Contras  
Apesar de suas vantagens, o **Abstract Factory** também apresenta pontos negativos:  
- **Complexidade maior**: Mais interfaces e classes, o que pode ser exagero em projetos simples.  
- **Dificuldade de adicionar novos produtos**: Alterar a estrutura para suportar novas famílias de objetos exige mudanças em todas as fábricas concretas.  
- **Sobrecarga de código**: Em casos onde poucas instâncias são necessárias, o padrão pode adicionar mais código do que o necessário.

