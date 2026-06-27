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