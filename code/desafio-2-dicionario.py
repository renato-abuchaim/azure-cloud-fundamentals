# Dicionário para mapear necessidades aos serviços Azure
servicos_azure = {
    "armazenar arquivos": "Azure Storage",
    "banco de dados relacional": "Azure SQL Database",
    "executar scripts sob demanda": "Azure Functions",
    "hospedar servidores virtuais": "Azure Virtual Machines"
}

# Lê a necessidade do usuário (entrada padrão)
necessidade = input().strip()

# Retorna o serviço correspondente ou "Servico desconhecido"
print(servicos_azure.get(necessidade, "Servico desconhecido"))