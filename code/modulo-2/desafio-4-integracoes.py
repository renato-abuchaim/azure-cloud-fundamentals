# Lê a entrada do usuário representando o tipo de integração
tipo_integracao = input().strip()

# Lógica condicional para definir o deploy
if tipo_integracao == "api":
    print("Deploy API Gateway")
elif tipo_integracao == "function":
    print("Deploy Azure Function")
elif tipo_integracao == "logicapp":
    print("Deploy Logic App")
else:
    print("Tipo de integracao desconhecido")