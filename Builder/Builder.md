# Builder – Design Pattern (GoF)

## 📜 Breve História  
O **Builder** foi descrito pelo *Gang of Four* (GoF) no livro *"Design Patterns: Elements of Reusable Object-Oriented Software"* (1994).  
A motivação original veio da necessidade de criar objetos complexos passo a passo, sem que o código cliente precise lidar diretamente com a montagem detalhada.  
Ele faz parte do grupo **Criacional** e seu foco é **separar a construção de um objeto da sua representação final**, permitindo que o mesmo processo de construção possa criar diferentes representações.

---

## 🎯 Quando Utilizar / Qual Problema Soluciona  
Você deve considerar o uso do **Builder** quando:  
- O objeto a ser criado é **complexo** e possui muitos atributos opcionais.  
- Deseja **controlar o processo de criação** em etapas bem definidas.  
- Quer evitar **construtores longos** e sobrecarregados com muitos parâmetros.  
- Precisa criar diferentes **variações** de um mesmo objeto usando o mesmo processo de construção.  

**Problema solucionado:**  
Em objetos com muitos parâmetros (especialmente opcionais), o construtor tradicional pode se tornar confuso e propenso a erros. O **Builder** organiza o processo de criação em etapas, facilitando a leitura, manutenção e garantindo maior clareza na montagem de objetos.

---

## ⚠️ Contras  
Apesar de suas vantagens, o **Builder** também apresenta pontos negativos:  
- **Mais classes**: A implementação exige a criação de um *Builder* separado, aumentando a quantidade de código.  
- **Pode ser exagero em objetos simples**: Em casos onde o objeto tem poucos atributos, o padrão adiciona complexidade desnecessária.  
- **Curva de aprendizado**: Para quem não conhece o padrão, pode parecer uma estrutura mais complicada do que um construtor tradicional.


