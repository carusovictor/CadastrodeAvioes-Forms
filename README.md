#  Sistema de Cadastro de Aviões

Aplicação desktop desenvolvida em **C# e Windows Forms**, com banco de dados **MySQL**, para cadastrar e gerenciar aviões e companhias aéreas.

##  Objetivo

Projeto acadêmico criado para praticar interfaces gráficas, programação em C# e operações de cadastro, consulta, edição e exclusão (CRUD) com banco de dados.

##  Funcionalidades

- Login de usuário;
- Cadastro de aviões (modelo, capacidade, ano de fabricação e companhia aérea);
- Consulta e busca de aviões;
- Edição e exclusão de registros;
- Cadastro de companhias aéreas.

##  Tecnologias

**C#**, **Windows Forms**, **.NET Framework 4.7.2**, **MySQL** e **Visual Studio**.

## 💻 Instalação e execução

1. Instale o **Visual Studio** (com suporte a desenvolvimento desktop .NET) e o **MySQL Server**.
2. Clone o repositório:
   ```bash
   git clone https://github.com/carusovictor/CadastrodeAvioes-Forms.git
   ```
3. No MySQL, crie o banco `banco_siscadastro` e importe o arquivo `DumpBancoCadastro.sql`.
4. Configure as *stored procedures* e a autenticação usadas pelo sistema. **Atenção:** esses scripts não estão incluídos no arquivo SQL do repositório.
5. Ajuste usuário e senha do MySQL em `SistemaCadastro/ConectaBanco.cs` (não publique credenciais reais).
6. Abra `SistemaCadastro.sln` no Visual Studio, restaure os pacotes se necessário e pressione **F5** para executar.

##  Capturas de tela

### Tela de login

> <img width="397" height="216" alt="image" src="https://github.com/user-attachments/assets/908c62f1-e540-4956-b7d2-a5443a1dea80" />


### Cadastro de aviões

> <img width="620" height="326" alt="image" src="https://github.com/user-attachments/assets/d02d95f0-774c-413a-9200-e996d285762d" />


### Consulta e busca

> <img width="617" height="325" alt="image" src="https://github.com/user-attachments/assets/afea1578-fe82-4d46-91d3-945941941be4" />


### Cadastro de companhias

> <img width="398" height="218" alt="image" src="https://github.com/user-attachments/assets/efba489e-94a9-4a91-80b2-b94fc18ed3b7" />


Projeto acadêmico de graduação.
