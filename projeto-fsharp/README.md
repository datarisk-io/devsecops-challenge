# API em F#

Nosso time de desenvolvimento criou essa simples API utilizando a linguagem F#,
e agora é o momento de transformá-la em um container. Para isso você pode
adicionar um **Dockerfile** a este projeto.

Não iremos definir qual imagem base você deve utilizar, pois essa escolha também
faz parte do desafio.

## Intruções de uso

Como dito anteriormente, este projeto foi criado utilizando a linguagem F#, que
é uma linguagem de programação de vários paradigmas para a plataforma .NET.

### Requisitos locais

Para executar o projeto localmente, é necessário que você tenha o seguinte SDK
instalado:

* .NET SDK 6.x

Você pode verificar quais versões estão instaladas em seu sistema usando esse
comando:

``` shell
dotnet --list-sdks
```

### Restaurar pacotes

Em seguida, devemos restaurar os pacotes necessários para executar o
projeto. Para facilitar esse processo, criamos o script disponibilizado no
arquivo `restore.sh` na raíz deste diretório.

Basta então executá-lo:

``` shell
./restore.sh
```

### Iniciar o servidor

Após restaurar as dependências, podemos iniciar o servidor utilizando o comando:

``` shell
dotnet fake run build.fsx -t "Run"
```

Após executar este comando, espera-se que o servidor esteja escutando na porta
**8085**.

### Testar os endpoints

Por fim, podemos testar os endpoints da aplicação diretamente utilizando
curl. Por exemplo:

``` shell
# GET
curl -X GET "http://0.0.0.0:8085/endpoint/get/hello"
# POST
curl -X POST "http://0.0.0.0:8085/endpoint/post/message"
# PUT
curl -X PUT "http://0.0.0.0:8085/endpoint/put/message"
# DELETE
curl -X DELETE "http://0.0.0.0:8085/endpoint/delete/nothing"
```

### Nix

Para facilitar o setup local, disponibilizamos alguns arquivos de configuração
para criação de um nix shell. Fique a vontade para usá-lo nos testes locais.

No momento de criação do desafio foi utilizado o *Nix versão 2.11.1*:

``` shell
nix-shell shell.nix
```

