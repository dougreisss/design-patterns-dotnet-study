# Facade – Design Pattern (GoF)

## 📜 Breve História  
O **Facade** foi descrito pelo *Gang of Four* (GoF) no livro *"Design Patterns: Elements of Reusable Object-Oriented Software"* (1994).  
Ele pertence ao grupo **Estrutural** e surgiu para fornecer uma **interface simplificada** para um conjunto complexo de classes, bibliotecas ou subsistemas.  
A ideia é esconder a complexidade interna e expor apenas o que é essencial para o cliente.

---

## 🎯 Quando Utilizar / Qual Problema Soluciona  
Você deve considerar o uso do **Facade** quando:  
- Precisa **simplificar o acesso** a um sistema ou subsistema complexo.  
- Deseja criar uma **interface única e coesa** que reúna funcionalidades dispersas.  
- Quer **reduzir o acoplamento** entre o cliente e as classes internas de um subsistema.  
- Precisa fornecer **múltiplas camadas de abstração** em um sistema grande (ex.: API de alto nível).  

**Problema solucionado:**  
Sistemas grandes tendem a expor muitas classes, métodos e dependências, tornando o uso complexo e de difícil manutenção.  
O **Facade** atua como uma **porta de entrada** simplificada, escondendo detalhes internos e facilitando a vida do cliente.

---

## ⚠️ Contras  
Apesar das vantagens, o **Facade** apresenta alguns pontos negativos:  
- **Pode virar um “Deus”**: Se mal projetado, o Facade pode concentrar muita lógica, fugindo de seu propósito de apenas simplificar o acesso.  
- **Não elimina a complexidade real**: Apenas a esconde — os detalhes ainda existem dentro do subsistema.  
- **Risco de abstração excessiva**: Pode dificultar o acesso a funcionalidades mais avançadas ou específicas do subsistema.  
