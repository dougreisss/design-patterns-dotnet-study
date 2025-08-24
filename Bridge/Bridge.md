# Bridge – Design Pattern (GoF)

## 📜 Breve História  
O **Bridge** foi descrito pelo *Gang of Four* (GoF) no livro *"Design Patterns: Elements of Reusable Object-Oriented Software"* (1994).  
Ele surgiu para resolver o problema do **crescimento explosivo de subclasses** quando uma classe precisa variar em múltiplas dimensões.  
Esse padrão pertence ao grupo **Estrutural** e seu objetivo é **separar a abstração da implementação**, permitindo que ambas possam evoluir de forma independente.

---

## 🎯 Quando Utilizar / Qual Problema Soluciona  
Você deve considerar o uso do **Bridge** quando:  
- Uma classe precisa variar em **duas ou mais dimensões** (ex.: forma + cor, janela + sistema operacional).  
- Deseja **reduzir o acoplamento** entre abstração e implementação.  
- Quer **evitar a explosão de subclasses** que acontece ao tentar combinar múltiplas variações diretamente por herança.  
- Precisa que a **abstração e a implementação possam ser estendidas independentemente**.  

**Problema solucionado:**  
Sem o Bridge, quando temos múltiplas dimensões de variação, a herança tradicional cria uma **árvore de subclasses muito grande e difícil de manter**.  
O Bridge resolve isso delegando a implementação para outra hierarquia de classes, tornando o sistema mais flexível e modular.

---

## ⚠️ Contras  
Apesar de suas vantagens, o **Bridge** apresenta desvantagens:  
- **Complexidade adicional**: Introduz novas abstrações e camadas de código, o que pode ser excesso em sistemas simples.  
- **Pode dificultar a leitura inicial**: Para quem não conhece o padrão, entender a separação entre abstração e implementação pode não ser imediato.  
- **Sobrecarga estrutural**: Em projetos pequenos, pode ser mais prático usar herança simples ao invés de aplicar Bridge.

