## Conversor de Temperatura

Este projeto é uma aplicação Windows Forms desenvolvida em C# que implementa um conversor de temperatura entre Celsius, Fahrenheit e Kelvin. A aplicação foi criada como parte do aprendizado de Programação Orientada a Objetos (POO), encapsulamento e boas práticas de desenvolvimento em C#.

## Funcionalidades

A aplicação possui as seguintes funcionalidades:

- Conversão de temperatura entre Celsius, Fahrenheit e Kelvin.
- Interface gráfica amigável para inserção de valores e seleção das unidades de temperatura.
- Verificação de entrada para assegurar que o usuário insira valores válidos antes de realizar a conversão.
- Limpeza dos campos de entrada e saída para uma nova conversão.

## Implementação

### Programação Orientada a Objetos (POO)
O projeto segue os princípios da Programação Orientada a Objetos. Cada tipo de temperatura (Celsius, Kelvin e Fahrenheit) foi implementado em uma classe separada, encapsulando seus respectivos métodos e atributos. Isso facilita a manutenção e extensão do código, além de promover o reuso de código.

### Encapsulamento
Os atributos de temperatura em cada classe são protegidos por meio de propriedades privadas, e métodos públicos são utilizados para acessar e manipular esses dados, garantindo o encapsulamento.

### Classes

- **ClassCelsius**: Responsável por armazenar e manipular a temperatura em Celsius.
- **ClassKelvin**: Responsável por armazenar e manipular a temperatura em Kelvin.
- **ClassFahrenheit**: Responsável por armazenar e manipular a temperatura em Fahrenheit.

Cada classe possui métodos para converter a temperatura para as outras unidades, promovendo a separação de responsabilidades.

### Interface Gráfica
A interface gráfica foi criada utilizando o Windows Forms, onde o usuário pode inserir o valor da temperatura e escolher a unidade de medida. A interface exibe os resultados das conversões em duas outras unidades.

## Tecnologias Utilizadas

- C#
- Windows Forms
- .NET Framework

## Como Usar

1. Insira o valor da temperatura no campo de entrada.
2. Selecione a unidade de temperatura (Celsius, Fahrenheit ou Kelvin) no campo de seleção.
3. Clique no botão "Calcular" para realizar a conversão.
4. Os valores convertidos serão exibidos nos campos de resultado.
5. Utilize o botão "Limpar" para limpar os campos e realizar uma nova conversão.

## Exemplo de Uso

Se o usuário inserir o valor `100` na caixa de texto e selecionar "Celsius" como unidade, a aplicação irá exibir o valor correspondente em Fahrenheit e Kelvin.

## Conclusão

Este projeto demonstrou a aplicação dos conceitos fundamentais de POO, como encapsulamento e modularidade, além do uso de componentes gráficos para criar uma interface de usuário interativa. A estrutura modular facilita futuras extensões e adaptações do código, garantindo uma aplicação robusta e eficiente.

