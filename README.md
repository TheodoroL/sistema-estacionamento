# Sistema de Estacionamento - README

Este projeto é um sistema simples de gerenciamento de estacionamento, desenvolvido em C# para fins didáticos. Ele permite adicionar, remover e listar veículos, além de calcular o valor a ser pago pelo tempo de permanência no estacionamento.

## Estrutura do Projeto

- `Program.cs`: Ponto de entrada da aplicação.
- `model/Estacionamento.cs`: Classe principal que implementa as regras de negócio do estacionamento.

## Funcionamento da Classe `Estacionamento`

### Propriedades

- `PrecoInicial`: Valor inicial cobrado ao estacionar.
- `PrecoPorHora`: Valor cobrado por cada hora adicional.

### Métodos

- `AdicionarVeiculo()`: Solicita ao usuário a placa do veículo, valida a entrada e adiciona à lista de veículos estacionados, evitando duplicidade.
- `RemoverVeiculo()`: Solicita a placa do veículo, verifica se está estacionado, pede a quantidade de horas e calcula o valor total a ser pago. Remove o veículo da lista.
- `ListarVeiculos()`: Exibe todas as placas dos veículos atualmente estacionados. Caso não haja veículos, informa ao usuário.
- `ObterVeiculos()`: Retorna uma lista somente leitura dos veículos estacionados (útil para integrações futuras).
- `CalcularValor(int horas)`: Método privado que calcula o valor total a ser pago com base no tempo de permanência.

### Validações

- Não permite placas em branco ou nulas.
- Não permite valores negativos para preços.
- Não permite remover veículos que não estejam estacionados.
- Não permite adicionar veículos duplicados.

## Exemplo de Uso

Ao rodar o programa, o usuário pode:

- Adicionar um veículo informando a placa.
- Remover um veículo informando a placa e o tempo de permanência.
- Listar todos os veículos estacionados.

## Observações

- O sistema utiliza o console para interação com o usuário.
- O código segue boas práticas de encapsulamento e validação.

---
