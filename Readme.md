# Exemplo de Injeção de Dependência em C#

Este projeto demonstra o uso do padrão de Injeção de Dependência (Dependency Injection) em C# para tratamento e registro de erros.

## Objetivo

O objetivo é mostrar como desacoplar a lógica de logging da lógica de negócio, facilitando a manutenção e a extensão do sistema. O projeto permite alternar facilmente entre diferentes mecanismos de log, como gravação em arquivo ou no Visualizador de Eventos do Windows, apenas mudando a implementação da interface de logger.

## Estrutura

- [`DependencyInjection.IErrorLogger`](DependencyInjection/IErrorLogger.cs): Interface para abstração do mecanismo de log.
- [`DependencyInjection.FileLogger`](DependencyInjection/FileLogger.cs): Implementação que registra erros em arquivo.
- [`DependencyInjection.EventViewerLogger`](DependencyInjection/EventViewerLogger.cs): Implementação que registra erros no Visualizador de Eventos do Windows.
- [`DependencyInjection.OperationEvent`](DependencyInjection/OperationEvent.cs): Classe de exemplo que executa uma operação e utiliza o logger para registrar exceções.
- `App.config`: Arquivo de configuração com parâmetros para logging.

## Como usar

1. Clone o repositório e abra a solução no Visual Studio.
2. Compile o projeto.
3. Execute o projeto para ver o tratamento de exceções e o registro de erros conforme a implementação de logger escolhida.

## Exemplo de execução

Ao executar uma operação de divisão por zero, a exceção será capturada e registrada pelo logger configurado.

## Licença

Este projeto é fornecido para fins educacionais.