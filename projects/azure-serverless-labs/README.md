# ☁️ Azure Serverless Labs

![Azure](https://img.shields.io/badge/Azure-Serverless-blue?logo=microsoftazure)
![Azure Functions](https://img.shields.io/badge/Azure%20Functions-v4-purple)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)
![Architecture](https://img.shields.io/badge/Architecture-Event%20Driven-green)
![Status](https://img.shields.io/badge/Status-Completed-success)

---

# 📖 Sobre o Projeto

O **Azure Serverless Labs** é um laboratório prático desenvolvido com **Azure Functions .NET 8** para demonstrar diferentes cenários de computação serverless utilizando serviços da Microsoft Azure.

O projeto reúne exemplos de:

* processamento de arquivos em Blob Storage;
* consumo de mensagens do Azure Service Bus;
* persistência de dados em Azure SQL Database;
* execução automática via Timer Trigger;
* exposição de endpoints HTTP.

O objetivo é simular uma arquitetura moderna orientada a eventos, aplicando conceitos utilizados em ambientes corporativos e soluções cloud-native.

---

## Estrutura

Em construção.

---

# 🏗️ Arquitetura

O projeto utiliza uma arquitetura orientada a eventos baseada em Azure Functions.

```text
HTTP Request
      │
      ▼
fn-simples

Blob Upload
      │
      ▼
fn-input-blob

Service Bus Queue
      │
      ▼
fn-ler-sb

HTTP Request
      │
      ▼
fn-save-sql
      │
      ▼
Azure SQL Database

Timer Trigger
      │
      ▼
fn-tempo
```
---

# 📂 Estrutura do Projeto

```text
azure-serverless-labs/
│
├── README.md
├── .gitignore
├── AzureServerlessLabs.sln
│
├── fn-input-blob/
│   ├── BlobProcessorFunction.cs
│   ├── Program.cs
│   ├── fn-input-blob.csproj
│   ├── host.json
│   ├── serviceDependencies.json
│   ├── serviceDependencies.local.json
│   ├── Properties/
│   │   └── launchSettings.json
│   └── ServiceDependencies/
│       └── local/
│           └── storage2.arm.json
│
├── fn-ler-sb/
│   ├── ServiceBusConsumerFunction.cs
│   ├── Program.cs
│   ├── fn-ler-sb.csproj
│   ├── host.json
│   ├── serviceDependencies.json
│   ├── serviceDependencies.local.json
│   └── Properties/
│       └── launchSettings.json
│
├── fn-save-sql/
│   ├── SqlPersistenceFunction.cs
│   ├── ClienteItem.cs
│   ├── Program.cs
│   ├── fn-save-sql.csproj
│   ├── host.json
│   ├── serviceDependencies.json
│   ├── serviceDependencies.local.json
│   └── Properties/
│       └── launchSettings.json
│
├── fn-simples/
│   ├── HttpTriggerFunction.cs
│   ├── Program.cs
│   ├── fn-simples.csproj
│   ├── host.json
│   ├── serviceDependencies.json
│   ├── serviceDependencies.local.json
│   └── Properties/
│       └── launchSettings.json
│
└── fn-tempo/
    ├── ScheduledTaskFunction.cs
    ├── Program.cs
    ├── fn-tempo.csproj
    ├── host.json
    ├── serviceDependencies.json
    ├── serviceDependencies.local.json
    └── Properties/
        └── launchSettings.json

```

---

# 🚀 Laboratórios Disponíveis

## 🟪 fn-simples

### HttpTriggerFunction

Função HTTP básica utilizada para validação do ambiente e testes de execução.

**Trigger:** HTTP Trigger

**Cenários:**

* Testes locais;
* Health checks;
* Endpoints simples.

---

## 🟦 fn-input-blob

### BlobProcessorFunction

Executada automaticamente quando um arquivo é enviado para um container Blob Storage.

**Triggers e Bindings:**

* Blob Trigger
* Blob Input
* Blob Output

**Cenários:**

* Processamento de arquivos;
* Pipelines orientados a eventos;
* Integração com Storage Account.

---

## 🟨 fn-ler-sb

### ServiceBusConsumerFunction

Consome mensagens do Azure Service Bus e realiza integração com sistemas externos.

**Trigger:** Service Bus Trigger

**Cenários:**

* Processamento assíncrono;
* Comunicação desacoplada;
* Integração entre aplicações.

---

## 🟩 fn-save-sql

### SqlPersistenceFunction

Recebe dados via HTTP e persiste registros utilizando SQL Output Binding.

**Trigger:** HTTP Trigger

**Binding:** SQL Output Binding

**Cenários:**

* Persistência de dados;
* APIs serverless;
* Integração com banco de dados.

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