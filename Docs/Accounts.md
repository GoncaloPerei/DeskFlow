# 🔑 Dados de Teste (Mock Data):

Para facilitar a avaliação e os testes do sistema **DeskFlow** em memória RAM, a aplicação pré-carrega automaticamente um conjunto de utilizadores fictícios no arranque (`App.xaml.cs`). 

Abaixo encontram-se as credenciais divididas por perfil de acesso para testar as regras de negócio e os portais autónomos.

---

## 👤 Portal de Clientes
Estes utilizadores têm acesso exclusivo ao histórico pessoal, abertura de tickets e chat de intervenções.

| Nome | Email | Password | Empresa Associada |
| :--- | :--- | :--- | :--- |
| Carlos Santos | `carlos2000@gmail.com` | `123` | Santos & Filhos Lda. |
| Maria Ferreira | `maria.ferreira@techcorp.pt` | `123` | TechCorp SA |

---

## 🛠️ Portal de Técnicos
Estes utilizadores têm acesso à fila de tickets global, captura de ticket, inserção de intervencoes técnicas e fecho de ocorrências.

| Nome | Email | Password | Especialização |
| :--- | :--- | :--- | :--- |
| Ana Costa | `ana.costa@deskflow.com` | `123` | Redes e Infraestrutura |
| Rui Jorge | `rui.jorge@deskflow.com` | `123` | Software e Sistemas |

---

## 💡 Notas Importantes para a Avaliação
* **Persistência Temporária:** Como o sistema opera inteiramente em memória, qualquer novo utilizador registado ou alteração de password feita em tempo de execução será resetada ao fechar a aplicação, voltando a vigorar as credenciais desta tabela.
* **Segurança de Teste:** Todas as palavras-passe foram definidas como `123` para simplificar e agilizar o processo de login durante a defesa prática do projeto.