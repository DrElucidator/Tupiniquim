![Demo](https://github.com/user-attachments/assets/7ada58aa-51f8-4cc2-8b32-5c70361cad61)

# RoboTupiniquim.ConsoleApp

Um projeto em **C# Console Application** que simula o movimento de um robô em uma grade 2D.  
O robô recebe comandos para girar à esquerda (`E`), girar à direita (`D`) e mover-se para frente (`M`), atualizando sua posição e orientação a cada passo.

---

## Funcionalidades
- Representação de um robô em uma grade de 5x5.
- Movimentos controlados por uma sequência de comandos (`EMEMEMEMM`).
- Atualização visual da grade a cada comando.
- Exibição da posição inicial e final do robô.
- Interação passo a passo: o usuário pressiona **ENTER** para avançar cada comando.

---

## Estrutura do Código
- **Classe `Robot`**:  
  Contém a lógica de movimento, rotação e configuração inicial do robô.
- **Classe `Program`**:  
  Responsável por inicializar a grade, executar os comandos e mostrar o estado atual da simulação.

---

## Como Executar
1. Clone este repositório:
   ```bash
   git clone https://github.com/seuusuario/Tupiniquim.git
   ```
2. Acesse a pasta do projeto:
   ```bash
   cd RoboTupiniquim.ConsoleApp
   ```
3. Compile e execute:
   ```bash
   dotnet run
   ```

---

## 📖 Exemplo de Saída

```
Posição inicial do Robô Tupiniquim: 1 2 N
Pressione ENTER para avançar...
(Posição atual exibida na grade)
...
Posição final do Robô Tupiniquim: 3 1 N
```

Durante a execução, a grade é atualizada mostrando a posição do robô (`R`) e os espaços já percorridos (`.`).

---

## Tecnologias Utilizadas
- **C# 10**
- **.NET 6 Console Application**

---

## Objetivo
Este projeto foi desenvolvido para praticar:
- Manipulação de arrays bidimensionais.
- Estruturação de classes e métodos em C#.
- Simulação de lógica de movimento em um ambiente discreto.
- Interação simples com o usuário via console.