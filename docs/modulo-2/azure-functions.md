# Azure Functions

![Azure Functions](../images/module-2/azure-functions-overview.png)

## Introdução

O Azure Functions é o serviço de computação **Serverless** da Microsoft Azure. Ele permite executar pequenos blocos de código sob demanda, sem a necessidade de criar ou administrar servidores.

Em vez de manter uma aplicação executando continuamente, o Azure Functions inicia a execução apenas quando ocorre um evento específico, conhecido como **Trigger**.

Essa abordagem reduz custos, simplifica o desenvolvimento e oferece escalabilidade automática.

---

# O que é Serverless?

Serverless é um modelo de desenvolvimento em nuvem onde a infraestrutura é totalmente gerenciada pelo provedor da plataforma.

Embora servidores ainda existam, eles ficam totalmente transparentes para o desenvolvedor.

As principais responsabilidades da plataforma incluem:

- Provisionamento automático da infraestrutura;
- Escalabilidade horizontal;
- Atualizações da plataforma;
- Monitoramento;
- Alta disponibilidade.

Nesse modelo, o desenvolvedor precisa se preocupar apenas com o código da aplicação.

---

# O que são Azure Functions?

Azure Functions é um serviço de computação serverless da Microsoft Azure que permite executar funções individuais de maneira independente, sendo acionadas automaticamente por eventos.

Cada função possui um propósito específico e pode responder a diferentes tipos de eventos, como:

- Requisições HTTP;
- Upload de arquivos;
- Mensagens em filas;
- Agendamentos;
- Eventos da plataforma Azure.

Essa arquitetura facilita a construção de aplicações desacopladas, escaláveis e orientadas a eventos.

---

# Arquitetura Básica

![Bindings](../images/module-2/azure-functions-bindings.png)

Uma Azure Function é composta basicamente por três elementos:

```text
Evento (Trigger)
        │
        ▼
 Azure Function
        │
        ▼
Bindings / Serviços Azure
```

O **Trigger** inicia a execução da função.

Os **Bindings** facilitam a comunicação com outros serviços da Azure sem necessidade de implementar toda a lógica de conexão.

---

# Arquitetura Serverless

Em aplicações modernas, normalmente o fluxo acontece da seguinte forma:

```text
Evento
   │
   ▼
Azure Function
   │
   ├────────► Azure SQL
   │
   ├────────► Blob Storage
   │
   ├────────► Service Bus
   │
   ├────────► Event Grid
   │
   └────────► APIs Externas
```

Esse modelo permite construir aplicações altamente desacopladas e escaláveis.

---

# Escalabilidade Automática

Uma das principais vantagens das Azure Functions é sua escalabilidade automática.

Quando há aumento na quantidade de eventos, novas instâncias são criadas automaticamente.

Quando a demanda diminui, essas instâncias são encerradas automaticamente.

Esse processo acontece sem intervenção do desenvolvedor.

---

# Linguagens Suportadas

O Azure Functions possui suporte para diversas linguagens de programação.

Entre elas:

- C#
- Java
- JavaScript
- TypeScript
- Python
- PowerShell
- F#
- Custom Handlers

Essa flexibilidade permite utilizar a linguagem mais adequada para cada projeto.

---

# Triggers

Os **Triggers** são responsáveis por iniciar a execução de uma Azure Function.

Cada função possui apenas um Trigger.

Os principais são:

| Trigger | Descrição |
|----------|-----------|
| HTTP Trigger | Executa via requisições HTTP |
| Timer Trigger | Executa em horários programados |
| Blob Trigger | Executa após upload de arquivos |
| Queue Trigger | Executa ao receber mensagens em filas |
| Event Grid Trigger | Executa ao receber eventos do Azure Event Grid |
| Event Hub Trigger | Processamento de streaming de eventos |
| Service Bus Trigger | Processamento de mensagens do Azure Service Bus |
| Cosmos DB Trigger | Executa após alterações em documentos |

---

## HTTP Trigger

É utilizado para criar APIs REST e endpoints HTTP.

Exemplos:

- GET
- POST
- PUT
- DELETE

Muito utilizado para microsserviços.

---

## Timer Trigger

Executa automaticamente conforme um agendamento configurado.

Casos de uso:

- Backups;
- Relatórios automáticos;
- Limpeza de dados;
- Rotinas recorrentes.

---

## Blob Trigger

É acionado sempre que um arquivo é enviado para um container do Azure Blob Storage.

Aplicações:

- Processamento de imagens;
- ETL;
- Importação de arquivos;
- Conversão de documentos.

---

## Queue Trigger

Executa automaticamente quando uma mensagem é inserida em uma fila do Azure Storage Queue.

Muito utilizado para processamento assíncrono.

---

## Event Grid Trigger

Permite responder automaticamente aos eventos publicados pelo Azure Event Grid.

É amplamente utilizado em arquiteturas Event Driven.

---

## Service Bus Trigger

Executa quando novas mensagens chegam ao Azure Service Bus.

Muito utilizado para comunicação desacoplada entre sistemas.

---

# Bindings

Bindings permitem integrar a Azure Function com outros serviços sem escrever código de conexão.

Existem dois tipos.

## Input Binding

Recebe dados automaticamente de outro serviço.

Exemplos:

- Blob Storage;
- Cosmos DB;
- Queue Storage.

---

## Output Binding

Grava informações automaticamente em outro serviço.

Exemplos:

- Azure SQL;
- Blob Storage;
- Service Bus;
- Queue Storage.

Os Bindings reduzem significativamente a quantidade de código necessária para integração.

---

# Templates Disponíveis

Ao criar uma Azure Function, diversos modelos podem ser utilizados.

Os principais são:

- HTTP Trigger
- Timer Trigger
- Blob Trigger
- Queue Trigger
- Event Grid Trigger
- Event Hub Trigger
- Service Bus Queue Trigger
- Service Bus Topic Trigger

Cada template já cria toda a estrutura inicial do projeto.

---

# Azure Functions Core Tools

O Azure Functions Core Tools permite desenvolver e testar funções localmente.

Principais comandos:

Inicializar um projeto:

```bash
func init
```

Criar uma nova Function:

```bash
func new
```

Executar localmente:

```bash
func start
```

Esses comandos facilitam o desenvolvimento antes da publicação na Azure.

---

# Deploy

Uma Azure Function pode ser publicada utilizando diferentes ferramentas.

As principais são:

- Visual Studio
- Visual Studio Code
- Azure CLI
- GitHub Actions
- Azure DevOps

Após o deploy, a função passa a responder automaticamente aos eventos configurados.

---

# Vantagens

Entre os principais benefícios das Azure Functions estão:

- Escalabilidade automática;
- Alta disponibilidade;
- Modelo Pay as You Go;
- Baixo custo operacional;
- Desenvolvimento rápido;
- Integração nativa com serviços Azure;
- Excelente para arquiteturas orientadas a eventos;
- Ideal para microsserviços.

---

# Casos de Uso

Alguns exemplos de utilização:

- APIs REST;
- Processamento de arquivos;
- Integração entre sistemas;
- Automação de processos;
- Processamento de filas;
- Internet das Coisas (IoT);
- ETL;
- Envio de notificações;
- Jobs agendados.

---

# Relação com este Repositório

Neste repositório, esses conceitos são aplicados no projeto:

```text
projects/
└── azure-serverless-labs/
```

O laboratório demonstra, na prática, diferentes tipos de Azure Functions utilizando:

- HTTP Trigger;
- Timer Trigger;
- Blob Trigger;
- Service Bus Trigger;
- Azure SQL Output Binding.

Esse projeto consolida os principais conceitos de computação Serverless estudados durante o módulo.

---

# Conclusão

Azure Functions é uma das principais soluções Serverless da Microsoft Azure.

Sua capacidade de executar código sob demanda, escalar automaticamente e integrar diversos serviços da plataforma permite construir aplicações modernas, desacopladas e altamente escaláveis, reduzindo custos e simplificando o gerenciamento da infraestrutura.