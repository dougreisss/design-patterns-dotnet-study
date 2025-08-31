# Proxy – Design Pattern (GoF)

## 📜 Breve História  
O **Proxy** foi descrito pelo *Gang of Four* (GoF) no livro *"Design Patterns: Elements of Reusable Object-Oriented Software"* (1994).  
Ele pertence ao grupo **Estrutural** e tem como objetivo **controlar o acesso a um objeto** através de um substituto (proxy).  
Esse padrão é muito utilizado quando é necessário **adicionar lógica extra** antes de acessar o objeto real, como segurança, logging, cache ou controle de recursos.

---

## 🎯 Quando Utilizar / Qual Problema Soluciona  
Você deve considerar o uso do **Proxy** quando:  
- Precisa **controlar o acesso** a um objeto.  
- Deseja **adiar a criação** ou o carregamento de um objeto "pesado" até o momento em que ele realmente for necessário (*Proxy Virtual*).  
- Precisa aplicar **camadas de segurança** para restringir acessos (*Proxy de Proteção*).  
- Deseja adicionar **cache ou logging** sem modificar o objeto real (*Proxy Remoto / Proxy de Cache*).  

**Problema solucionado:**  
Sem o Proxy, o cliente acessaria diretamente o objeto real, o que pode ser **custoso, inseguro ou pouco flexível**.  
O Proxy resolve isso fornecendo um **substituto** que controla esse acesso e pode executar ações adicionais.

---

## ⚠️ Contras  
Apesar das vantagens, o **Proxy** apresenta algumas desvantagens:  
- **Complexidade extra**: Adiciona mais classes e camadas de abstração.  
- **Impacto em performance**: Dependendo da lógica dentro do proxy, pode introduzir latência extra.  
- **Manutenção**: É necessário garantir que o Proxy mantenha a mesma interface do objeto real, o que pode gerar trabalho adicional.  
