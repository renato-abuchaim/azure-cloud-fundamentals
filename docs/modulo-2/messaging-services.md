# Mensageria e Serviços de Comunicação na Microsoft Azure

![Azure Service Bus](/images/modulo-2/azure-service-bus.png)

## Introdução

Em arquiteturas modernas distribuídas, nem sempre os sistemas precisam se comunicar de forma imediata.

Para reduzir o acoplamento entre aplicações, melhorar a escalabilidade e aumentar a confiabilidade, utilizam-se mecanismos de **mensageria** e **arquiteturas orientadas a eventos**.

A Microsoft Azure oferece diversos serviços para esse tipo de comunicação, sendo os principais:

- Azure Service Bus
- Azure Event Grid

Esses serviços permitem que aplicações troquem informações de maneira segura, assíncrona e altamente escalável.

---

# Mensagens x Eventos

Embora muitas vezes sejam utilizados juntos, mensagens e eventos possuem objetivos diferentes.

## Mensagens

Uma mensagem representa um conjunto de dados enviado de um sistema para outro.

Normalmente o sistema que envia espera que outro sistema processe essa informação.

As mensagens podem conter dados em diversos formatos:

- JSON
- XML
- Texto
- Bytes
- Objetos serializados

Exemplos:

- Pedido realizado
- Cliente cadastrado
- Nota fiscal emitida

Nesse modelo existe uma expectativa de processamento da mensagem.

---

## Eventos

Um evento representa apenas uma notificação de que algo aconteceu.

Quem publica o evento não sabe quem irá consumi-lo.

O consumidor decide o que fazer com essa informação.

Exemplos:

- Arquivo enviado
- Usuário autenticado
- Produto atualizado
- Cliente removido

Esse modelo é conhecido como **Publisher/Subscriber (Pub/Sub)**.

---

# Comunicação Assíncrona

Uma das maiores vantagens da mensageria é permitir comunicação assíncrona.

Em vez de esperar uma resposta imediata entre sistemas, as mensagens ficam armazenadas até que possam ser processadas.

```text
Aplicação A
      │
      ▼
Fila
      │
      ▼
Aplicação B
```

Esse modelo oferece:

- maior disponibilidade;
- menor acoplamento;
- melhor distribuição de carga;
- maior tolerância a falhas.

---

# Azure Service Bus

![Azure Service Bus](/images/modulo-2/service-bus-queue.png)

O Azure Service Bus é o serviço de mensageria empresarial da Microsoft Azure.

Ele foi desenvolvido para conectar aplicações distribuídas de maneira segura e confiável.

Entre seus principais recursos estão:

- Filas (Queues);
- Tópicos (Topics);
- Assinaturas (Subscriptions);
- Dead Letter Queue;
- Agendamento de mensagens;
- Detecção de duplicidade;
- Controle de concorrência.

---

# Filas (Queues)

As filas são utilizadas para comunicação entre dois sistemas.

O produtor envia mensagens para uma fila.

O consumidor lê essas mensagens quando estiver disponível.

```text
Produtor
    │
    ▼
 Queue
    │
    ▼
Consumidor
```

Cada mensagem normalmente é processada apenas uma vez.

---

## Quando utilizar Filas?

As filas são indicadas para cenários como:

- processamento assíncrono;
- envio de e-mails;
- integração entre sistemas;
- filas de pedidos;
- processamento em background;
- distribuição de carga.

---

# Benefícios das Filas

Entre os principais benefícios estão:

- desacoplamento entre aplicações;
- processamento em horários diferentes;
- balanceamento de carga;
- tolerância a falhas;
- maior escalabilidade.

---

# Tópicos (Topics)

![Service Bus Topics](/images/modulo-2/service-bus-topics.png)

Os tópicos permitem que uma única mensagem seja entregue para vários consumidores.

Enquanto uma fila possui normalmente um consumidor, um tópico pode possuir diversas assinaturas independentes.

```text
             Topic
               │
      ┌────────┼────────┐
      ▼        ▼        ▼
 Subscription Subscription Subscription
```

Esse modelo segue o padrão **Publish/Subscribe**.

---

# Assinaturas (Subscriptions)

Cada assinatura funciona como uma fila independente.

Cada consumidor recebe sua própria cópia da mensagem.

Isso permite que diferentes sistemas processem o mesmo evento sem interferir uns nos outros.

Exemplo:

Uma aplicação publica:

```text
Cliente cadastrado
```

As assinaturas podem executar ações diferentes:

- CRM
- Financeiro
- Marketing
- Analytics

Todos recebem a mesma informação.

---

# Dead Letter Queue (DLQ)

Nem sempre uma mensagem consegue ser processada com sucesso.

Quando isso acontece repetidamente, ela pode ser enviada para uma fila especial chamada **Dead Letter Queue**.

A Dead Letter Queue armazena mensagens com erro para posterior análise.

Principais causas:

- dados inválidos;
- falha na aplicação;
- tempo limite;
- exceção durante o processamento;
- excesso de tentativas.

Esse recurso evita perda de mensagens.

---

# Azure Event Grid

![Azure Event Grid](/images/modulo-2/azure-event-grid.png)

O Azure Event Grid é o serviço da Microsoft Azure responsável pelo gerenciamento de eventos.

Seu funcionamento é baseado no padrão **Publish/Subscribe**.

Em vez de enviar mensagens diretamente para consumidores específicos, um evento é publicado e diversos sistemas podem decidir se desejam processá-lo.

---

# Publisher e Subscriber

O modelo do Event Grid possui dois papéis principais.

## Publisher

É quem gera os eventos.

Exemplos:

- Blob Storage;
- Azure Functions;
- Event Hub;
- Aplicações Web;
- APIs.

---

## Subscriber

São as aplicações que recebem os eventos.

Exemplos:

- Azure Functions;
- Logic Apps;
- Event Hubs;
- Service Bus;
- WebHooks.

---

# Arquitetura do Event Grid

![Arquitetura Event Grid](/images/modulo-2/event-grid-architecture.png)

Fluxo simplificado:

```text
Publisher
     │
     ▼
Azure Event Grid
     │
 ┌───┼────┐
 ▼   ▼    ▼
App1 App2 App3
```

Cada consumidor decide como tratar o evento recebido.

---

# Service Bus x Event Grid

| Azure Service Bus | Azure Event Grid |
|-------------------|------------------|
| Trabalha com mensagens | Trabalha com eventos |
| Espera processamento | Apenas notifica |
| Comunicação ponto a ponto | Comunicação Publish/Subscribe |
| Possui filas e tópicos | Distribuição de eventos |
| Alta confiabilidade | Alta escalabilidade |

---

# Casos de Uso

## Azure Service Bus

- Processamento de pedidos;
- Integração entre sistemas;
- Comunicação entre microsserviços;
- Processamento em background;
- Filas de trabalho.

---

## Azure Event Grid

- Upload de arquivos;
- Eventos do Azure Storage;
- Notificações automáticas;
- Automação de processos;
- Integração baseada em eventos.

---

# Relação com este Repositório

Os conceitos apresentados neste documento são utilizados diretamente no laboratório:

```text
projects/
└── azure-serverless-labs/
```

No projeto são demonstrados cenários como:

- processamento de mensagens utilizando **Azure Service Bus**;
- consumo de filas através de **Service Bus Trigger**;
- integração entre Azure Functions e serviços Azure;
- arquitetura orientada a eventos utilizando recursos serverless.

---

# Conceitos Aprendidos

Durante este módulo foram estudados:

- Comunicação síncrona e assíncrona;
- Mensagens e eventos;
- Azure Service Bus;
- Filas;
- Tópicos;
- Assinaturas;
- Dead Letter Queue;
- Azure Event Grid;
- Publisher e Subscriber;
- Arquiteturas Event Driven.

---

# Conclusão

Os serviços de mensageria da Microsoft Azure permitem construir aplicações desacopladas, resilientes e altamente escaláveis.

Enquanto o **Azure Service Bus** é ideal para comunicação confiável baseada em mensagens, o **Azure Event Grid** simplifica arquiteturas orientadas a eventos, permitindo que múltiplos sistemas reajam automaticamente às mudanças ocorridas na plataforma.