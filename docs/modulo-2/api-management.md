# Gerenciamento de APIs com Azure API Management

![Azure API Management](../images/module-2/api-management-subscriptions.png)

## Introdução

À medida que aplicações e microsserviços crescem, torna-se necessário controlar como as APIs são publicadas, protegidas, monitoradas e consumidas.

O **Azure API Management (APIM)** é o serviço da Microsoft Azure responsável por gerenciar APIs de forma centralizada, oferecendo recursos de segurança, autenticação, monitoramento, documentação e controle de acesso.

Com ele é possível disponibilizar APIs para clientes internos e externos de maneira organizada e segura.

---

# O que é Azure API Management?

O Azure API Management é uma plataforma que atua como uma camada intermediária entre os consumidores e os serviços de backend.

Ele permite:

- publicar APIs;
- proteger APIs;
- controlar o acesso;
- aplicar políticas;
- monitorar consumo;
- documentar serviços;
- facilitar o gerenciamento de múltiplas APIs.

Em vez de acessar diretamente uma API, os clientes realizam chamadas para o **Gateway do API Management**, que encaminha as requisições para o backend.

---

# Arquitetura Geral

```text
Cliente
    │
    ▼
Azure API Management
    │
    ▼
API Gateway
    │
    ▼
Backend Services
```

Todo o tráfego passa pelo Gateway antes de chegar às aplicações.

---

# Componentes do Azure API Management

O serviço é composto por diversos componentes que trabalham em conjunto.

## API Gateway

O Gateway é o principal componente do Azure API Management.

Ele funciona como um **proxy reverso**, recebendo todas as solicitações feitas pelos consumidores.

Entre suas responsabilidades estão:

- autenticação;
- autorização;
- roteamento;
- limitação de chamadas;
- transformação de mensagens;
- monitoramento;
- aplicação de políticas.

---

## Portal do Azure

É utilizado pelos administradores para:

- criar APIs;
- configurar políticas;
- criar produtos;
- gerenciar usuários;
- monitorar métricas;
- administrar assinaturas.

---

## Portal do Desenvolvedor

É um portal disponibilizado para consumidores das APIs.

Nele é possível:

- visualizar documentação;
- testar endpoints;
- obter chaves de acesso;
- realizar assinaturas;
- consultar exemplos de uso.

---

# Produtos (Products)

No Azure API Management, as APIs normalmente são organizadas em **Produtos**.

Um produto representa um conjunto de uma ou mais APIs disponibilizadas para um determinado grupo de usuários.

Cada produto pode possuir:

- regras de acesso;
- limites de utilização;
- políticas específicas;
- necessidade de assinatura.

Exemplo:

```text
Produto Clientes

├── API Cadastro
├── API Pedidos
└── API Financeiro
```

---

# Grupos (Groups)

Os grupos controlam quem pode visualizar e utilizar determinados produtos.

Exemplos de grupos:

- Administradores
- Desenvolvedores
- Parceiros
- Clientes
- Equipe Interna

Isso permite controlar o acesso às APIs conforme o perfil do usuário.

---

# Desenvolvedores (Developers)

Cada consumidor das APIs pode possuir uma conta cadastrada no API Management.

Os desenvolvedores conseguem:

- acessar documentação;
- testar APIs;
- solicitar assinaturas;
- utilizar chaves de acesso;
- acompanhar consumo.

---

# Políticas (Policies)

Um dos maiores diferenciais do Azure API Management são as **Policies**.

As políticas permitem modificar o comportamento das APIs sem alterar o código da aplicação.

Elas são executadas automaticamente pelo Gateway.

---

# O que uma Policy pode fazer?

Alguns exemplos:

- validar autenticação;
- bloquear usuários;
- limitar requisições;
- transformar cabeçalhos;
- alterar respostas;
- registrar logs;
- encaminhar chamadas;
- validar certificados;
- aplicar CORS.

---

# Estrutura das Policies

As políticas são escritas em XML.

Sua estrutura básica é:

```xml
<policies>

    <inbound>

    </inbound>

    <backend>

    </backend>

    <outbound>

    </outbound>

    <on-error>

    </on-error>

</policies>
```

Cada seção representa uma etapa do processamento da requisição.

---

# Principais Políticas

Algumas das políticas mais utilizadas são:

- Rate Limit
- Quota
- Forward Request
- Validate JWT
- Find and Replace
- CORS
- Cache
- Retry
- Authentication
- Log to Event Hub

Essas políticas podem ser combinadas conforme a necessidade da aplicação.

---

# Subscription Keys

Uma das formas mais comuns de proteger APIs no Azure é utilizando **Subscription Keys**.

Cada consumidor recebe uma chave exclusiva.

Toda chamada para a API deve enviar essa chave.

Normalmente ela é enviada no cabeçalho:

```http
Ocp-Apim-Subscription-Key
```

Caso a chave seja inválida, o acesso é negado.

---

# Escopos das Chaves

As Subscription Keys podem ser criadas para diferentes níveis.

- Todas as APIs
- Produto específico
- API específica

Isso permite controlar exatamente quem pode acessar determinado recurso.

---

# OAuth 2.0

Além das Subscription Keys, o Azure API Management possui suporte ao protocolo **OAuth 2.0**.

O OAuth permite autenticação utilizando provedores externos.

Exemplos:

- Microsoft Entra ID (Azure AD)
- Google
- GitHub
- Facebook
- Identity Server

Esse modelo é recomendado para aplicações modernas.

---

# Certificados

Outra forma de proteger APIs é utilizando certificados digitais.

O Azure API Management suporta autenticação baseada em certificados TLS.

É possível validar:

- Autoridade Certificadora (CA)
- Impressão digital (Thumbprint)
- Emissor
- Assunto
- Data de validade

Essa abordagem é bastante utilizada em integrações entre empresas.

---

# Segurança

O Azure API Management oferece diversos mecanismos de segurança.

Entre eles:

- HTTPS
- OAuth 2.0
- JWT
- Subscription Keys
- Certificados
- Rate Limiting
- IP Filtering
- Políticas de acesso
- Controle de usuários

Esses recursos ajudam a proteger as APIs contra acessos indevidos e abusos.

---

# Benefícios do Azure API Management

Entre as principais vantagens estão:

- Centralização do gerenciamento de APIs;
- Segurança integrada;
- Facilidade para publicar APIs;
- Controle de acesso;
- Monitoramento em tempo real;
- Documentação automática;
- Escalabilidade;
- Integração com diversos serviços Azure.

---

# Relação com este Repositório

Os conceitos apresentados neste documento são utilizados nos projetos desenvolvidos durante este curso, principalmente em cenários onde APIs podem ser publicadas e protegidas através do Azure.

Projetos relacionados:

```text
projects/
├── employee-management-api/
└── azure-serverless-labs/
```

Embora os laboratórios utilizem Azure Functions e Web APIs, eles podem ser publicados futuramente utilizando o Azure API Management como camada de gerenciamento.

---

# Conceitos Aprendidos

Durante este módulo foram estudados:

- Azure API Management;
- API Gateway;
- Produtos;
- Grupos;
- Desenvolvedores;
- Políticas (Policies);
- XML Policies;
- Subscription Keys;
- OAuth 2.0;
- Certificados;
- Segurança de APIs.

---

# Conclusão

O Azure API Management é uma solução completa para gerenciamento de APIs na Microsoft Azure.

Além de simplificar a publicação e documentação de serviços, ele fornece mecanismos avançados de autenticação, autorização, monitoramento e segurança, permitindo construir arquiteturas escaláveis, organizadas e preparadas para ambientes corporativos.