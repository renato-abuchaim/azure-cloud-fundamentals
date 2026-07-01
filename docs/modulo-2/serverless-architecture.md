# Arquitetura Serverless com Microsoft Azure

![Serverless Overview](/images/modulo-2/serverless-overview.png)

## Introdução

A computação **Serverless** representa uma evolução no desenvolvimento de aplicações em nuvem, permitindo que desenvolvedores concentrem seus esforços exclusivamente na lógica de negócio, enquanto toda a infraestrutura é gerenciada automaticamente pelo provedor de cloud.

Na Microsoft Azure, esse modelo é implementado principalmente através do **Azure Functions**, possibilitando criar aplicações altamente escaláveis, orientadas a eventos e com cobrança baseada apenas no consumo de recursos.

---

# O que é Serverless?

Apesar do nome significar "sem servidor", servidores continuam existindo.

A principal diferença é que toda a infraestrutura é administrada automaticamente pela plataforma de nuvem.

O desenvolvedor não precisa se preocupar com:

- provisionamento de servidores;
- atualizações do sistema operacional;
- configuração da infraestrutura;
- escalabilidade;
- balanceamento de carga.

Seu foco passa a ser apenas o desenvolvimento da aplicação.

---

# Características do Modelo Serverless

As aplicações serverless possuem algumas características importantes:

- execução sob demanda;
- cobrança por utilização;
- escalabilidade automática;
- gerenciamento de infraestrutura pela plataforma;
- rápida implantação (Deploy);
- integração nativa com diversos serviços da Azure.

---

# Arquitetura Monolítica

![Arquitetura Monolítica vs Microsserviços](/images/modulo-2/monolith-vs-microservices.png)

Em uma arquitetura monolítica toda a aplicação é desenvolvida como um único sistema.

```text
Aplicação

├── Autenticação
├── Pedidos
├── Financeiro
├── Produtos
└── Clientes
```

Embora seja simples para aplicações pequenas, esse modelo apresenta algumas limitações.

### Vantagens

- Desenvolvimento inicial simples;
- Implantação única;
- Menor complexidade arquitetural.

### Desvantagens

- Escalabilidade limitada;
- Alto acoplamento;
- Atualizações mais complexas;
- Uma falha pode afetar toda a aplicação.

---

# Arquitetura de Microsserviços

Na arquitetura baseada em microsserviços, cada funcionalidade é desenvolvida de forma independente.

```text
Cliente

├── API Produtos
├── API Pedidos
├── API Financeiro
└── API Clientes
```

Cada serviço pode ser implantado, atualizado e escalado separadamente.

Essa abordagem facilita a manutenção e melhora a disponibilidade da aplicação.

---

# Arquitetura Serverless

![Arquitetura Serverless](/images/modulo-2/serverless-architecture.png)

O modelo Serverless leva a arquitetura distribuída um passo além.

Em vez de aplicações completas, executam-se pequenas funções responsáveis por tarefas específicas.

Exemplo:

```text
HTTP Request
      │
      ▼
Azure Function

Blob Upload
      │
      ▼
Azure Function

Service Bus
      │
      ▼
Azure Function

Timer
      │
      ▼
Azure Function
```

Cada função é executada somente quando ocorre um evento.

---

# Arquitetura Orientada a Eventos (Event Driven)

Grande parte das aplicações serverless utiliza o padrão **Event Driven Architecture (EDA)**.

Nesse modelo, a execução acontece somente quando um evento é disparado.

Exemplos de eventos:

- upload de arquivos;
- recebimento de mensagens;
- requisições HTTP;
- alteração em banco de dados;
- execução agendada;
- eventos publicados pelo Azure Event Grid.

Essa abordagem reduz o consumo de recursos e melhora a eficiência da aplicação.

---

# Escalabilidade Automática

Uma das maiores vantagens da arquitetura serverless é sua capacidade de escalar automaticamente.

Conforme o número de eventos aumenta, a plataforma cria novas instâncias das funções para atender à demanda.

Quando a carga diminui, essas instâncias são removidas automaticamente.

O desenvolvedor não precisa configurar servidores adicionais ou realizar balanceamento manual.

---

# Modelo Pay as You Go

No modelo Serverless, a cobrança ocorre apenas pelos recursos efetivamente utilizados.

Esse conceito é conhecido como **Pay as You Go**.

A cobrança considera fatores como:

- número de execuções;
- tempo de processamento;
- memória utilizada.

Caso nenhuma função seja executada, normalmente não há custo de processamento.

Isso torna o modelo bastante econômico para aplicações com demanda variável.

---

# Cold Start

Uma característica comum em plataformas serverless é o **Cold Start**.

Quando uma função permanece inativa por um período, sua infraestrutura pode ser descarregada.

Na próxima execução, a plataforma precisa inicializar novamente o ambiente.

Esse tempo adicional é chamado de **Cold Start**.

Após a primeira execução, as próximas chamadas costumam ocorrer de forma muito mais rápida.

---

# Vantagens da Arquitetura Serverless

Entre os principais benefícios estão:

- não exige gerenciamento de servidores;
- escalabilidade automática;
- menor custo operacional;
- pagamento baseado em consumo;
- implantação simplificada;
- integração com diversos serviços Azure;
- desenvolvimento mais rápido;
- maior foco na lógica da aplicação.

---

# Desvantagens

Apesar das vantagens, existem alguns pontos que devem ser considerados:

- possibilidade de Cold Start;
- maior dependência do provedor de nuvem;
- limitações de tempo de execução;
- maior complexidade para depuração distribuída;
- monitoramento mais sofisticado.

---

# Quando Utilizar Serverless?

O modelo Serverless é recomendado para cenários como:

- APIs pequenas;
- microsserviços;
- processamento de arquivos;
- integração entre sistemas;
- automações;
- tarefas agendadas;
- processamento de mensagens;
- aplicações orientadas a eventos;
- workloads com demanda variável.

Já aplicações que executam processamento contínuo ou possuem alta utilização constante podem se beneficiar de outras abordagens, como máquinas virtuais ou contêineres.

---

# Relação com este Repositório

Os conceitos apresentados neste documento são aplicados diretamente no laboratório desenvolvido durante este curso:

```text
projects/
└── azure-serverless-labs/
```

Nesse projeto foram implementadas diversas Azure Functions demonstrando cenários como:

- HTTP Trigger;
- Blob Trigger;
- Service Bus Trigger;
- Timer Trigger;
- integração com Azure SQL Database;
- arquitetura orientada a eventos.

Esse laboratório consolida na prática os principais conceitos da arquitetura Serverless utilizando Microsoft Azure.

---

# Conceitos Aprendidos

Durante este módulo foram estudados:

- Computação Serverless;
- Azure Functions;
- Arquitetura Monolítica;
- Microsserviços;
- Arquitetura Orientada a Eventos;
- Escalabilidade Automática;
- Pay as You Go;
- Cold Start;
- Vantagens e Desvantagens;
- Casos de uso para aplicações Serverless.

---

# Conclusão

A arquitetura Serverless permite desenvolver aplicações modernas, escaláveis e altamente eficientes, eliminando a necessidade de gerenciamento direto da infraestrutura.

Aliada aos serviços da Microsoft Azure, essa abordagem simplifica o desenvolvimento de soluções distribuídas, reduz custos operacionais e favorece a criação de sistemas desacoplados e orientados a eventos, características fundamentais das aplicações cloud-native.