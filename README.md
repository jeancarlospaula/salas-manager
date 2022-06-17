# Gerenciador de Vendas

Projeto desenvolvido em C# e Windows Forms com objetivo de realizar o gerenciamento de vendas e seus produtos.

- É possível adicionar uma venda e, em seguida, vincular um produto a venda em andamento.
- Ao adicionar vendas e produtos, um arquivo JSON é gerado para simular um banco de dados.
- Quando o software inicia, o JSON é carregado e o sistema volta a apresentar as informações salvas.
- Ao finalizar uma venda, um arquivo JSON é gerado especificamente com os dados da venda e seus produtos, além de removê-los do "banco de dados" (em JSON) principal.

### Tela principal
![image](https://user-images.githubusercontent.com/79765050/174411189-35e16cb9-de17-4aac-b4f9-40f93231dde4.png)

#### Arquivo JSON gerado pelo sistema ao finalizar uma venda
``` JSON
{
  "venda": {
    "Id": "2",
    "Cliente": "Jean Carlos",
    "Endereço": "Paraná",
    "situação": "FINALIZADA"
  },
  "produtos": [
    {
      "Id": "2",
      "Nome": "Mouse",
      "Descricao": "Sem fio",
      "Quantidade": 4,
      "VendaId": "2"
    },
    {
      "Id": "3",
      "Nome": "Monitor",
      "Descricao": "30 polegadas",
      "Quantidade": 1,
      "VendaId": "2"
    }
  ]
}
```
