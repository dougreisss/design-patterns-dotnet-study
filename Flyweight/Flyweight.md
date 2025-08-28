# Flyweight – Design Pattern (GoF)

## 📜 Breve História  
O **Flyweight** foi descrito pelo *Gang of Four* (GoF) no livro *"Design Patterns: Elements of Reusable Object-Oriented Software"* (1994).  
Ele pertence ao grupo **Estrutural** e surgiu para **reduzir o consumo de memória** ao compartilhar instâncias de objetos que possuem dados comuns, evitando duplicações desnecessárias.  
O padrão é muito útil em sistemas que criam **grande quantidade de objetos semelhantes**.

---

## 🎯 Quando Utilizar / Qual Problema Soluciona  
Você deve considerar o uso do **Flyweight** quando:  
- Precisa criar **muitos objetos semelhantes** que consomem muita memória.  
- Há possibilidade de **compartilhar o estado intrínseco** entre objetos, separando-o do estado extrínseco que varia.  
- Quer **melhorar a performance** em termos de uso de memória e velocidade de instância.  

**Problema solucionado:**  
Sem o Flyweight, sistemas que criam grande quantidade de objetos podem **consumir muita memória** e gerar overhead.  
O Flyweight resolve isso compartilhando **dados imutáveis** entre múltiplas instâncias, mantendo apenas o estado que realmente varia em cada objeto.

---

## ⚠️ Contras  
Apesar das vantagens, o **Flyweight** apresenta algumas desvantagens:  
- **Complexidade adicional**: Introduz camadas de abstração e necessidade de separar estado intrínseco e extrínseco.  
- **Gerenciamento do estado extrínseco**: É responsabilidade do cliente fornecer corretamente o estado que varia.  
- **Nem sempre necessário**: Para pequenas quantidades de objetos, o padrão adiciona complexidade sem ganho real.  
