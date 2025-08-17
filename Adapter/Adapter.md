# Adapter (Class Adapter) – Design Pattern (GoF)

## 📜 Breve História  
O **Adapter** foi descrito pelo *Gang of Four* (GoF) no livro *"Design Patterns: Elements of Reusable Object-Oriented Software"* (1994).  
O padrão surgiu da necessidade de integrar classes com **interfaces incompatíveis**, permitindo que trabalhem juntas sem alterações em seus códigos originais.  
Ele pertence ao grupo **Estrutural** e pode ser implementado de duas formas:  
- **Class Adapter** → usa **herança** para adaptar uma interface à outra.  
- **Object Adapter** → usa **composição** para adaptar uma interface à outra.  

---

## 🎯 Quando Utilizar / Qual Problema Soluciona  
Você deve considerar o uso do **Class Adapter** quando:  
- Precisa **reutilizar** uma classe existente, mas sua interface não é compatível com o código cliente.  
- Deseja fazer classes **incompatíveis trabalharem juntas** sem modificar seu código original.  
- Quer aplicar **herança múltipla** (quando suportada) para adaptar uma interface a outra.  

**Problema solucionado:**  
Permite que classes que originalmente não poderiam interagir passem a trabalhar juntas por meio de um adaptador. Isso facilita a integração de código legado ou bibliotecas externas sem a necessidade de alterar suas implementações.

---

## ⚠️ Contras  
Apesar das vantagens, o **Class Adapter** apresenta algumas desvantagens:  
- **Limitação pela herança**: Como depende de herança, não pode ser usado se a classe alvo já tiver outra superclasse (em linguagens que não suportam herança múltipla, como C# e Java).  
- **Maior acoplamento**: O adaptador fica rigidamente ligado à classe adaptada por meio da herança.  
- **Menos flexível que o Object Adapter**: Trocar a classe adaptada pode exigir reimplementação do adaptador.

