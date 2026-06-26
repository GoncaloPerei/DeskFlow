# 🔑 Mock Data (Test Accounts)

To simplify the evaluation and testing of the **DeskFlow** system in RAM, the application automatically preloads a set of mock users upon startup (`App.xaml.cs`). 

Below are the credentials split by access profile to test the business rules and autonomous portals.

---

## 👤 Customer Portal
These users have exclusive access to their personal ticket history, ticket creation, and the intervention chat.

| Name | Email | Password | Associated Company |
| :--- | :--- | :--- | :--- |
| Carlos Santos | `carlos2000@gmail.com` | `123` | Acme Portugal |
| Maria Rodrigues | `maria@inovacao.pt` | `123` | Inovação Digital |

---

## 🛠️ Technician Portal
These users have access to the global ticket queue, ticket assignment, technical interventions log, and ticket closure.

| Name | Email | Password | Specialization |
| :--- | :--- | :--- | :--- |
| Eng. Nuno Silva | `nuno.silva@deskflow.com` | `123` | Networks |
| Ana Costa | `ana.costa@deskflow.com` | `123` | Hardware |

---

## 💡 Important Notes for Evaluation
* **Temporary Persistence:** Since the system operates entirely in memory, any newly registered user or password change made at runtime will be reset upon closing the application, restoring the default credentials listed in the tables above.
* **Test Security:** All passwords have been set to `123` to simplify and streamline the login process during the project's practical defense.