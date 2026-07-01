# ⚙️ Modelos de Serviço em Cloud Computing

## 📖 Introdução

Os modelos de serviço em nuvem definem o nível de responsabilidade entre o provedor (ex: Microsoft Azure) e o cliente.

Isso determina o que é gerenciado pela nuvem e o que continua sob responsabilidade do usuário.

Os principais modelos são:

- 🖥️ IaaS (Infrastructure as a Service)
- ⚙️ PaaS (Platform as a Service)
- 🌐 SaaS (Software as a Service)

---

## 🖥️ IaaS — Infrastructure as a Service

![IaaS — Infrastructure as a Service](/images/modulo-1/iaas.png)

### 📌 Conceito

O provedor fornece a infraestrutura básica de TI, como:

- Máquinas virtuais
- Redes
- Armazenamento
- Datacenters virtuais

O cliente é responsável por:

- Sistema operacional
- Aplicações
- Dados
- Configurações internas

---

### 🧠 Exemplos reais

- Azure Virtual Machines
- AWS EC2
- Google Compute Engine

---

### 👍 Vantagens

- Alto nível de controle
- Flexibilidade para configurações avançadas
- Ideal para migração de sistemas legados

---

### ⚠️ Desvantagens

- Maior complexidade operacional
- Maior responsabilidade técnica
- Necessidade de gerenciamento constante

---

## ⚙️ PaaS — Platform as a Service

![PaaS — Platform as a Service](/images/modulo-1/paas.png)

### 📌 Conceito

O provedor gerencia toda a infraestrutura e plataforma.

O cliente foca apenas em:

- Código da aplicação
- Dados
- Deploy

---

### 🧠 Exemplos reais

- Azure App Service
- Google App Engine
- Heroku

---

### 👍 Vantagens

- Redução de esforço operacional
- Deploy mais rápido
- Foco total no desenvolvimento

---

### ⚠️ Desvantagens

- Menor controle sobre infraestrutura
- Limitações da plataforma
- Dependência do provedor

---

## 🌐 SaaS — Software as a Service

![SaaS — Software as a Service](/images/modulo-1/saas.png)

### 📌 Conceito

O software já está pronto e é entregue via internet.

O usuário apenas consome o serviço.

---

### 🧠 Exemplos reais

- Microsoft 365
- Google Workspace
- Dropbox
- Salesforce

---

### 👍 Vantagens

- Não requer instalação
- Acesso imediato
- Atualizações automáticas
- Facilidade de uso

---

### ⚠️ Desvantagens

- Baixa personalização
- Dependência do serviço
- Controle limitado

---

## 📊 Comparação dos Modelos

| Modelo | Controle | Gestão | Flexibilidade | Exemplo |
|--------|----------|--------|---------------|--------|
| IaaS   | Alto     | Cliente | Alta          | VM Azure |
| PaaS   | Médio    | Compartilhado | Média | App Service |
| SaaS   | Baixo    | Provedor | Baixa        | Microsoft 365 |

---

## 📈 SLA (Service Level Agreement)

### 📖 O que é SLA?

O SLA define o nível de disponibilidade garantido por um serviço em nuvem.

Ele representa o compromisso do provedor com o tempo de funcionamento (uptime).

---

### 🖼️ Visualização do SLA

![SLA - Disponibilidade de Serviços](/images/modulo-1/sla.png)

---

### 🧠 Exemplos práticos

- 99.9% SLA → até ~43 minutos de indisponibilidade por mês
- 99.99% SLA → até ~4 minutos de indisponibilidade por mês
- 99.999% SLA → nível crítico (quase zero downtime)

---

### ⚠️ Impacto no mundo real

Quanto maior o SLA:

- Maior a confiabilidade do sistema
- Maior o custo do serviço
- Maior a complexidade da infraestrutura

---

### 🧩 SLA em arquitetura cloud

SLA está diretamente ligado a:

- Alta disponibilidade
- Redundância de sistemas
- Failover automático
- Multi-region deployment

---

## 🧠 Responsabilidade Compartilhada

Na nuvem, segurança e operação são divididas entre provedor e cliente.

![Responsabilidade Compartilhada](/images/modulo-1/shared-responsibility-model.png)

### Exemplo:

| Camada | Responsável |
|--------|-------------|
| Hardware físico | Azure |
| Rede física | Azure |
| Sistema operacional | Cliente (IaaS) |
| Aplicações | Cliente |
| Dados | Cliente |

---

## 🎯 Resumo

Os modelos de serviço definem o nível de controle e responsabilidade na nuvem:

- 🖥️ IaaS → máximo controle
- ⚙️ PaaS → equilíbrio entre controle e produtividade
- 🌐 SaaS → máximo consumo, mínimo gerenciamento

O SLA complementa esses modelos garantindo confiabilidade e disponibilidade dos serviços.

---

## 🚀 Conclusão

Entender os modelos de serviço e SLA é essencial para projetar soluções escaláveis, seguras e eficientes na Microsoft Azure e em qualquer provedor de cloud.