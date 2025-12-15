# Validador de Cartão de Crédito Full Stack (DIO Challenge)

Este projeto foi desenvolvido como parte do desafio final do curso de .NET da **DIO**. O objetivo foi criar uma aplicação Full Stack capaz de validar números de cartão de crédito, identificando sua bandeira e verificando sua autenticidade matemática.

A aplicação foi construída separando as responsabilidades em uma API robusta no backend e uma interface interativa e visualmente agradável no frontend.

## Proposta e Regras de Negócio

O sistema recebe um número de cartão e aplica duas camadas de validação:

1.  **Algoritmo de Luhn:** Uma verificação matemática padrão de mercado para garantir que o número digitado é válido e não contém erros de digitação.
2.  **Identificação de Bandeira:** Verificação dos prefixos (BIN) para determinar a qual operadora o cartão pertence, seguindo as regras abaixo:

| Bandeira | Número inicial (Prefixos) |
| :--- | :--- |
| **Visa** | Começa sempre com o número **4**. |
| **MasterCard** | Começa com dígitos entre **51 e 55**, ou entre **2221 a 2720**. |
| **Elo** | Pode começar com vários intervalos, como **4011, 4312, 4389**, entre outros. |
| **American Express** | Inicia com **34 ou 37**. |
| **Discover** | Começa com **6011, 65**, ou com a faixa de **644 a 649**. |
| **Hipercard** | Geralmente começa com **6062**. |



## Tecnologias Utilizadas

O projeto foi estruturado utilizando uma arquitetura moderna de cliente-servidor:

* **Frontend:** Framework **Angular** (v17+).
    * Componentes Standalone.
    * Design System personalizado em CSS, com identidade visual em homenagem à DIO.
    * Interface interativa que simula um cartão físico.
* **Backend:** API RESTful em **.NET (C#)**.
    * Implementação do Algoritmo de Luhn.
    * Uso de Regex para identificação de padrões de bandeiras.



## Como Testar

Para verificar o funcionamento da aplicação com dados reais, recomenda-se o uso de geradores de números válidos para testes de desenvolvimento.

Durante o desenvolvimento deste projeto, foi utilizado o site **4devs** para gerar números de cartões válidos de diferentes bandeiras para assegurar que tanto a validação de Luhn quanto a identificação da bandeira estivessem corretas.

> **Nota:** O projeto contém, em sua pasta raiz, imagens demonstrando a aplicação em funcionamento e um print do código do algoritmo de Luhn implementado no C#.

---

## ⚙️ Como Rodar o Projeto Localmente

É necessário ter o **.NET SDK** e o **Node.js (com Angular CLI)** instalados.

### Passo 1: Rodar a API (Backend)

Abra um terminal na pasta `core-api` e execute:

```bash
cd core-api
dotnet run --urls="http://localhost:5000"
```
O backend estará rodando em http://localhost:5000.

### Passo 2: Rodar a Interface (Frontend)
Abra um segundo terminal na pasta frontend-angular e execute:

```bash
cd frontend-angular
npm install # Apenas na primeira vez para baixar dependências
ng serve
```
Acesse a aplicação no navegador em http://localhost:4200.

## Autor

**Augusto Ortigoso Barbosa**

* **GitHub:** [github.com/supp3rguto](https://github.com/supp3rguto)
* **LinkedIn:** [linkedin.com/in/augusto-barbosa-769602194](https://www.linkedin.com/in/augusto-barbosa-769602194)
