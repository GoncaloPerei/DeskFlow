# 🚀 DeskFlow - HelpDesk Desktop System

> **Projeto Prático da Unidade Curricular de Programação II**  
> Licenciatura em Engenharia Informática | **ISTEC Porto** (Ano Letivo 2025/2026)  
> **Autor:** Gonçalo Silva Pereira  
> **Docente:** João Rebelo  

---

## 📝 Sobre o DeskFlow
O **DeskFlow** é um sistema desktop de HelpDesk e suporte técnico concebido para otimizar a gestão de incidentes, fluxos de triagem e a comunicação entre clientes e técnicos. Desenvolvido inteiramente em **C#** com **WPF (Windows Presentation Foundation)**, o sistema foca-se na rapidez de resposta do operador e na aplicação rigorosa dos pilares da **Programação Orientada a Objetos (POO)**.

---

## 🔍 Descrição do Problema
As organizações modernas enfrentam grandes dificuldades em gerir pedidos de assistência por canais informais (e-mails, chamadas), resultando em:
* **Perda de rastreabilidade:** Incidentes pendentes sem controlo de estados.
* **Falta de priorização:** Incidentes críticos tratados com a mesma urgência que dúvidas simples.
* **Inexistência de histórico:** Dificuldade em associar o histórico de problemas a um cliente específico para identificar falhas recorrentes.

O **DeskFlow** resolve estas lacunas centralizando o fluxo de trabalho através de uma arquitetura modular baseada em memória RAM reativa.

---

## 🛠️ Stack Tecnológica & Especificações
* **Linguagem:** C# (C-Sharp)
* **Framework UI:** WPF (Windows Presentation Foundation) com XAML
* **Lógica de Dados:** Gestão de Estado em Memória RAM (`ObservableCollection<T>` e `List<T>`)
* **Consultas:** Expressões LINQ (*Language Integrated Query*)
* **IDE Recomendada:** Visual Studio 2022 ou superior

---

## 💎 Destaques de Programação II (Conceitos Aplicados)
Para cumprir as metas académicas de engenharia de software, o projeto destaca-se pela implementação de:
1. **Herança e Especialização:** Classe abstrata `Person` herdada pelas entidades especializadas `Customer` e `Technician`.
2. **Polimorfismo:** A propriedade `ClosedBy` (do tipo `Person`) aceita dinamicamente objetos de clientes ou técnicos no ato de encerramento do ticket.
3. **Associação e Composição:** Associação estrita entre utilizadores e chamados, com relação de composição estruturada no histórico de `Intervention` (intervenções em cascata).
4. **Arquitetura Limpa (Helpers):** Separação total da camada visual (Code-Behind) da camada de dados através de classes utilitárias estáticas (*Helpers*).

---

## 📦 Funcionalidades Principais (Features)

### 👤 Portal do Cliente
* Abertura de tickets com definição de **Título, Descrição e Prioridade** (Alta, Média, Baixa).
* Monitorização do histórico pessoal de ocorrências abertas.
* Chat de interação técnica através de mensagens e notas de suporte.
* Encerramento autónomo do chamado e gestão de dados de perfil.

### 🛠️ Portal do Técnico
* **Fila de Espera Global:** Listagem de tickets pendentes sem técnico associado.
* **Captura (Assignment):** Mecanismo via duplo clique para associar chamados à sua mesa de trabalho.
* Painel isolado "Os Meus Tickets" para gestão do fluxo de trabalho.
* Inserção de intervenções técnicas detalhadas na timeline do ticket.
* Encerramento definitivo de chamados com auditoria automática do utilizador que fechou.

---

## 📂 Estrutura da Documentação (`/docs`)
Dentro deste repositório, na pasta `/docs`, podes encontrar os artefactos visuais de modelação do sistema:
* 📊 **Diagrama de Classes (UML):** Detalhe de todas as propriedades, métodos, heranças e cardinalidades.
* 🗺️ **Diagrama de Casos de Utilização (Use Cases):** Mapeamento das permissões e interações de cada ator no sistema.

---

## 🚀 Como Executar o Projeto Localmente

1. Garante que tens o **Visual Studio 2022** instalado com a workload de `.NET Desktop Development`.
2. Clona este repositório para a tua máquina:
   ```bash
   git clone [https://github.com/o-teu-utilizador/DeskFlow.git](https://github.com/o-teu-utilizador/DeskFlow.git)