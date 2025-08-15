# Singleton – Design Pattern (GoF)

## 📜 Breve História  
O **Singleton** foi descrito pelo *Gang of Four* (GoF) no livro *"Design Patterns: Elements of Reusable Object-Oriented Software"* (1994).  
O padrão surgiu para garantir que uma classe tenha **apenas uma instância** e forneça um **ponto global de acesso** a ela.  
Ele pertence ao grupo **Criacional** e é frequentemente usado em casos onde recursos compartilhados ou configurações globais precisam ser centralizados.

---

## 🎯 Quando Utilizar / Qual Problema Soluciona  
Você deve considerar o uso do **Singleton** quando:  
- É necessário garantir que exista **somente uma instância** de uma classe no sistema.  
- Quer fornecer um **ponto de acesso global** a um recurso compartilhado.  
- Precisa controlar acesso a recursos críticos, como **conexões de banco**, **logs** ou **configurações globais**.

**Problema solucionado:**  
Evita a criação de múltiplas instâncias desnecessárias, que poderiam causar inconsistências ou desperdício de recursos. Além disso, simplifica o acesso a dados ou serviços que precisam ser únicos no sistema.

---

## ⚠️ Contras  
Apesar das vantagens, o **Singleton** apresenta algumas desvantagens:  
- **Dificulta testes unitários**: Instâncias globais podem gerar dependências implícitas e tornar testes mais complexos.  
- **Pode criar acoplamento forte**: Classes que usam o Singleton ficam dependentes de sua implementação específica.  
- **Problemas com concorrência**: Se não for implementado corretamente, pode gerar condições de corrida em ambientes multithread.  
- **Pode ser considerado um "anti-pattern"** se usado indiscriminadamente como substituto de injeção de dependência.

