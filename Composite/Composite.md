# Composite – Design Pattern (GoF)

## 📜 Breve História  
O **Composite** foi descrito pelo *Gang of Four* (GoF) no livro *"Design Patterns: Elements of Reusable Object-Oriented Software"* (1994).  
Ele pertence ao grupo **Estrutural** e surgiu para resolver problemas relacionados à **representação de hierarquias de objetos** em forma de árvore, permitindo tratar objetos individuais e composições de forma uniforme.  

---

## 🎯 Quando Utilizar / Qual Problema Soluciona  
Você deve considerar o uso do **Composite** quando:  
- Precisa representar **estruturas hierárquicas em árvore** (ex.: diretórios e arquivos, menus e submenus, organização empresarial).  
- Deseja que clientes tratem **objetos individuais e grupos de objetos da mesma forma**.  
- Quer aplicar **operações recursivas** sobre a estrutura sem precisar diferenciar se está lidando com um objeto simples ou um conjunto.  

**Problema solucionado:**  
Sem o Composite, seria necessário criar lógicas diferentes para lidar com objetos simples e compostos, aumentando a complexidade do código cliente.  
O Composite unifica o tratamento, permitindo que clientes interajam com ambos da mesma maneira através de uma **interface comum**.

---

## ⚠️ Contras  
Apesar das vantagens, o **Composite** também apresenta desvantagens:  
- **Pode tornar o design muito genérico**: Fica difícil restringir quais classes podem compor a hierarquia.  
- **Complexidade extra**: Introduz camadas adicionais de abstração que podem ser desnecessárias em cenários simples.  
- **Depuração mais difícil**: Em estruturas muito grandes, pode ser mais complicado rastrear erros ou entender a composição em tempo de execução.

