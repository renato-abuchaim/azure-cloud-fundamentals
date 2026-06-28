# ☁️ Azure Serverless Labs

![Azure](https://img.shields.io/badge/Azure-Serverless-blue?logo=microsoftazure)
![Azure Functions](https://img.shields.io/badge/Azure%20Functions-v4-purple)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)
![Serverless](https://img.shields.io/badge/Serverless-Azure-success)
![Event Driven](https://img.shields.io/badge/Event--Driven-Architecture-brightgreen)
![Git](https://img.shields.io/badge/Git-GitHub-orange)
![Status](https://img.shields.io/badge/Status-Completed-success)

---

# 📑 Índice

- [🎯 Objetivos](#-objetivos)
- [⚙️ Tecnologias Utilizadas](#️-tecnologias-utilizadas)
- [✨ Funcionalidades](#-funcionalidades)
- [📂 Estrutura do Projeto](#-estrutura-do-projeto)
- [🏗️ Arquitetura](#️-arquitetura)
- [📋 Resumo dos Laboratórios](#-resumo-dos-laboratórios)
- [🚀 Laboratórios](#-laboratórios)
- [🔄 Fluxos Demonstrados](#-fluxos-demonstrados)
- [🛠️ Pré-requisitos](#️-pré-requisitos)
- [⚙️ Configuração Local](#️-configuração-local)
- [▶️ Como Executar](#️-como-executar)
- [📚 Conceitos Demonstrados](#-conceitos-demonstrados)
- [🎓 Aprendizados](#-aprendizados)
- [🏁 Conclusão](#-conclusão)

---

# 📖 Sobre o Projeto

![Arquitetura do Projeto](images/project-architecture.png)

O **Azure Serverless Labs** é um laboratório prático desenvolvido com **Azure Functions utilizando .NET 8**, criado para explorar os principais conceitos de computação **Serverless** na Microsoft Azure.

Ao longo do projeto foram implementados diferentes cenários utilizando Azure Functions, demonstrando como aplicações orientadas a eventos podem integrar diversos serviços da plataforma Azure de forma escalável, desacoplada e de baixo custo operacional.

O laboratório reúne exemplos utilizando:

* Azure Functions
* Azure Blob Storage
* Azure Service Bus
* Azure SQL Database
* HTTP Trigger
* Timer Trigger
* Blob Trigger
* SQL Output Binding

Todo o projeto foi desenvolvido com foco educacional, servindo como base para o entendimento da arquitetura Serverless na Azure.

---

# 🎯 Objetivos

Este laboratório possui como objetivos principais:

* compreender o funcionamento das Azure Functions;
* explorar diferentes tipos de Triggers e Bindings;
* integrar múltiplos serviços da plataforma Azure;
* aplicar conceitos de arquitetura orientada a eventos;
* praticar o desenvolvimento de aplicações Serverless;
* construir um projeto prático para portfólio.

---

# ⚙️ Tecnologias Utilizadas

| Tecnologia | Finalidade |
|------------|------------|
| **C#** | Linguagem utilizada no desenvolvimento das Azure Functions |
| **.NET 8 (Isolated Worker)** | Plataforma utilizada para criação das Functions |
| **Azure Functions v4** | Execução de aplicações Serverless |
| **Azure Blob Storage** | Armazenamento e processamento de arquivos |
| **Azure Service Bus** | Comunicação assíncrona baseada em filas |
| **Azure SQL Database** | Persistência de dados utilizando SQL Output Binding |
| **Azure Functions Core Tools** | Execução e testes locais das Functions |
| **Visual Studio 2022 / VS Code** | Ambiente de desenvolvimento |
| **Git & GitHub** | Controle de versão e hospedagem do código |

---

# ✨ Funcionalidades

Este laboratório demonstra a implementação prática dos seguintes recursos da plataforma Microsoft Azure:

- Criação de Azure Functions utilizando .NET 8 (Isolated Worker)
- Desenvolvimento de APIs Serverless com HTTP Trigger
- Processamento automático de arquivos com Blob Trigger
- Consumo de mensagens utilizando Service Bus Trigger
- Execução de tarefas agendadas com Timer Trigger
- Utilização de Blob Input e Blob Output Bindings
- Persistência de dados com SQL Output Binding
- Execução local utilizando Azure Functions Core Tools
- Integração entre múltiplos serviços da Microsoft Azure
- Aplicação de uma arquitetura orientada a eventos (Event-Driven)
---

# 📂 Estrutura do Projeto

```text
azure-serverless-labs/
│
├── README.md
├── .gitignore
├── AzureServerlessLabs.sln
│
├── fn-simples/
│   ├── HttpTriggerFunction.cs
│   ├── Program.cs
│   └── ...
│
├── fn-input-blob/
│   ├── BlobProcessorFunction.cs
│   ├── Program.cs
│   └── ...
│
├── fn-ler-sb/
│   ├── ServiceBusConsumerFunction.cs
│   ├── Program.cs
│   └── ...
│
├── fn-save-sql/
│   ├── SqlPersistenceFunction.cs
│   ├── ClienteItem.cs
│   ├── Program.cs
│   └── ...
│
├── fn-tempo/
│   ├── ScheduledTaskFunction.cs
│   ├── Program.cs
│   └── ...
│
└── images/
    └── project-architecture.png
```

A solução está organizada em projetos independentes, onde cada Azure Function demonstra um cenário específico de computação Serverless e integração com serviços da Microsoft Azure.
```
Cada diretório representa um cenário independente de utilização das Azure Functions, permitindo estudar diferentes Triggers, Bindings e integrações com serviços da plataforma Microsoft Azure.

---

# 🏗️ Arquitetura

Cada laboratório da solução representa um cenário diferente de utilização das Azure Functions.

```text
                   Azure Functions

          ┌─────────────┬─────────────┬─────────────┐
          │             │             │             │
          ▼             ▼             ▼             ▼
    HTTP Trigger   Blob Trigger  Service Bus   Timer Trigger
          │             │             │             │
          ▼             ▼             ▼             ▼
     fn-simples   fn-input-blob   fn-ler-sb     fn-tempo
                          │
                          ▼
                 Azure Blob Storage

     HTTP Trigger
          │
          ▼
     fn-save-sql
          │
          ▼
   Azure SQL Database
```

---

# 📋 Resumo dos Laboratórios

Cada laboratório demonstra um cenário específico de utilização das Azure Functions, explorando diferentes tipos de Triggers, Bindings e integrações com serviços da plataforma Microsoft Azure.

| Laboratório | Trigger / Binding | Serviço Azure | Descrição |
|-------------|-------------------|---------------|-----------|
| **fn-simples** | HTTP Trigger | Azure Functions | Implementação de um endpoint HTTP para testes e validação da Function. |
| **fn-input-blob** | Blob Trigger + Blob Input/Output | Azure Blob Storage | Processamento automático de arquivos enviados para um container Blob. |
| **fn-ler-sb** | Service Bus Trigger | Azure Service Bus | Consumo assíncrono de mensagens publicadas em uma fila. |
| **fn-save-sql** | HTTP Trigger + SQL Output Binding | Azure SQL Database | Recebimento de requisições HTTP e persistência de dados no banco SQL. |
| **fn-tempo** | Timer Trigger | Azure Functions | Execução automática de tarefas utilizando agendamento baseado em CRON. |

---


# 🚀 Laboratórios

## 🟣 fn-simples

### HttpTriggerFunction

Função HTTP utilizada como exemplo inicial para criação de APIs Serverless.

**Trigger**

* HTTP Trigger

**Objetivos**

* testar o ambiente;
* validar a execução das Functions;
* criar endpoints simples.

---

## 🔵 fn-input-blob

### BlobProcessorFunction

Executada automaticamente quando um arquivo é enviado ao Azure Blob Storage.

**Bindings**

* Blob Trigger
* Blob Input
* Blob Output

**Objetivos**

* processamento automático de arquivos;
* pipelines orientados a eventos;
* integração com Storage Account.

---

## 🟡 fn-ler-sb

### ServiceBusConsumerFunction

Consome mensagens recebidas pelo Azure Service Bus.

**Trigger**

* Service Bus Trigger

**Objetivos**

* processamento assíncrono;
* comunicação desacoplada;
* integração entre aplicações.

---

## 🟢 fn-save-sql

### SqlPersistenceFunction

Recebe informações via HTTP e persiste registros utilizando SQL Output Binding.

**Bindings**

* HTTP Trigger
* SQL Output Binding

**Objetivos**

* persistência de dados;
* integração com banco SQL;
* APIs Serverless.

---

## 🔴 fn-tempo

### ScheduledTaskFunction

Executada automaticamente conforme cron configurado.

**Trigger**

* Timer Trigger

**Objetivos**

* automações;
* rotinas recorrentes;
* tarefas agendadas.

---

# 🔄 Fluxos Demonstrados

Os laboratórios simulam diferentes cenários de integração entre serviços da Microsoft Azure utilizando Azure Functions.

## 📁 Processamento de Arquivos

Quando um arquivo é enviado para um container do Azure Blob Storage, uma Azure Function é acionada automaticamente para realizar o processamento.

```text
Azure Blob Storage
        │
        ▼
Azure Function
(Blob Trigger)
        │
        ▼
Blob Output
```

---

## 📨 Processamento de Mensagens

Mensagens publicadas em uma fila do Azure Service Bus são consumidas automaticamente por uma Azure Function.

```text
Azure Service Bus
        │
        ▼
Azure Function
(Service Bus Trigger)
        │
        ▼
Processamento da Mensagem
```

---

## 💾 Persistência de Dados

Uma requisição HTTP envia informações para uma Azure Function, que utiliza SQL Output Binding para gravar os dados no Azure SQL Database.

```text
HTTP Request
        │
        ▼
Azure Function
(HTTP Trigger)
        │
        ▼
SQL Output Binding
        │
        ▼
Azure SQL Database
```

---

## ⏰ Execução Agendada

O Timer Trigger executa automaticamente tarefas em horários previamente definidos.

```text
Agendamento (CRON)
        │
        ▼
Azure Function
(Timer Trigger)
        │
        ▼
Execução da Rotina
```

---

# 🛠️ Pré-requisitos

Antes de executar este laboratório, certifique-se de possuir os seguintes recursos instalados em sua máquina:

### Ferramentas de Desenvolvimento

- .NET 8 SDK
- Azure Functions Core Tools v4
- Visual Studio 2022 ou Visual Studio Code
- Git

### Recursos na Microsoft Azure

Para executar todos os laboratórios também é recomendado possuir uma assinatura Microsoft Azure com os seguintes serviços disponíveis:

- Azure Functions
- Azure Storage Account
- Azure Service Bus
- Azure SQL Database

> **Observação:** Alguns laboratórios podem ser executados localmente utilizando o Azure Storage Emulator (Azurite) ou recursos equivalentes, porém a utilização de uma assinatura Azure proporciona uma experiência mais próxima de um ambiente real.

---

# ⚙️ Configuração Local

Crie um arquivo chamado:

```text
local.settings.json
```

Utilize a seguinte estrutura:

```json
{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "UseDevelopmentStorage=true",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet-isolated",

    "BlobStorageConnection": "<connection-string>",
    "ServiceBusConnection": "<connection-string>",
    "SqlConnectionString": "<connection-string>",

    "ApiUrl": "https://seu-endpoint"
  }
}
```

> **Observação:** Os valores das Connection Strings variam de acordo com os recursos criados na sua assinatura Azure.

---

# ▶️ Como Executar

Siga os passos abaixo para executar os laboratórios localmente.

## 1️⃣ Clonar o repositório

```bash
git clone https://github.com/seu-usuario/azure-serverless-labs.git
```

---

## 2️⃣ Acessar o diretório do projeto

```bash
cd azure-serverless-labs
```

---

## 3️⃣ Restaurar as dependências

Restaure todos os pacotes da solução.

```bash
dotnet restore AzureServerlessLabs.sln
```

---

## 4️⃣ Configurar o ambiente

Crie o arquivo `local.settings.json` em cada projeto Azure Function e configure as Connection Strings necessárias para os serviços Azure utilizados.

Consulte a seção **Configuração Local** deste README para utilizar o modelo sugerido.

---

## 5️⃣ Executar uma Azure Function

Cada laboratório pode ser executado individualmente.

Exemplo:

```bash
dotnet run --project fn-simples
```

---

## 6️⃣ Executar utilizando Azure Functions Core Tools

Também é possível iniciar uma Function utilizando o Azure Functions Core Tools.

Primeiro acesse a pasta do projeto desejado:

```bash
cd fn-simples
```

Depois execute:

```bash
func start
```

---

## 7️⃣ Testar a aplicação

Após iniciar a Azure Function, utilize um navegador, Postman ou outra ferramenta de testes para enviar requisições HTTP ou interagir com os serviços Azure utilizados por cada laboratório.

---

## 💡 Observações

- Os laboratórios podem ser executados de forma independente.
- Cada projeto possui sua própria configuração (`local.settings.json`).
- Alguns cenários exigem recursos previamente criados na assinatura Microsoft Azure, como Storage Account, Service Bus e Azure SQL Database.

---

# 📚 Conceitos Demonstrados

Durante o desenvolvimento deste laboratório foram explorados conceitos fundamentais relacionados ao desenvolvimento de aplicações Serverless e à integração entre serviços da Microsoft Azure.

## ☁️ Computação Serverless

- Azure Functions
- Serverless Computing
- Event-Driven Architecture
- Escalabilidade automática
- Pay-as-you-Go

---

## ⚡ Triggers e Bindings

- HTTP Trigger
- Blob Trigger
- Timer Trigger
- Service Bus Trigger
- Blob Input Binding
- Blob Output Binding
- SQL Output Binding

---

## 🔗 Integração entre Serviços

- Azure Blob Storage
- Azure Service Bus
- Azure SQL Database
- Processamento de arquivos
- Processamento assíncrono
- Persistência de dados

---

## 💻 Desenvolvimento

- APIs Serverless
- Comunicação desacoplada
- Organização de soluções .NET
- Execução local com Azure Functions Core Tools
- Configuração de ambientes utilizando `local.settings.json`

---

## 🏗️ Arquitetura

- Arquitetura orientada a eventos
- Processamento baseado em eventos
- Separação de responsabilidades
- Integração entre múltiplos serviços Azure

---

# 🎓 Aprendizados

O desenvolvimento deste laboratório proporcionou uma experiência prática na construção de aplicações Serverless utilizando a plataforma Microsoft Azure.

Ao longo da implementação foram consolidados conhecimentos em:

## ☁️ Computação em Nuvem

- Fundamentos de Serverless Computing
- Arquitetura orientada a eventos
- Escalabilidade automática
- Modelo de cobrança Pay-as-you-Go

---

## ⚡ Azure Functions

- Criação de Azure Functions utilizando .NET 8
- Configuração de Triggers e Bindings
- Execução local com Azure Functions Core Tools
- Organização de projetos Serverless

---

## 🔗 Integração entre Serviços Azure

- Processamento de arquivos com Azure Blob Storage
- Comunicação assíncrona utilizando Azure Service Bus
- Persistência de dados com Azure SQL Database
- Integração entre múltiplos serviços da plataforma Azure

---

## 💻 Desenvolvimento

- Construção de APIs Serverless
- Configuração de ambientes utilizando `local.settings.json`
- Estruturação de soluções .NET com múltiplos projetos
- Aplicação de boas práticas de organização de código

---

## 🌱 Boas Práticas

- Documentação técnica utilizando Markdown
- Organização de projetos para portfólio
- Versionamento com Git e GitHub
- Estruturação de laboratórios para fins de estudo e evolução contínua

---

# 💼 Competências Desenvolvidas

Ao concluir este laboratório foram desenvolvidas competências relacionadas a:

- Azure Functions
- Serverless Computing
- Event-Driven Architecture
- Azure Blob Storage
- Azure Service Bus
- Azure SQL Database
- Triggers & Bindings
- APIs REST
- .NET 8
- Git
- GitHub
- Documentação Técnica

---

# 🏁 Conclusão

O **Azure Serverless Labs** demonstra, de forma prática, como construir aplicações modernas utilizando Azure Functions e serviços Serverless da Microsoft Azure.

Embora desenvolvido com fins educacionais, o projeto reúne conceitos amplamente utilizados em aplicações cloud-native, proporcionando uma base sólida para estudos sobre arquitetura orientada a eventos, integração entre serviços e desenvolvimento de soluções escaláveis na nuvem.
