# csharp-journey

Learning C# and the .NET ecosystem to transition into backend/API development. This repo tracks my progress, projects, and notes along the way.

**Background:** Coming from Python
**Focus:** ASP.NET Core, Web APIs, backend development, FullStack Development
**Pace:** ~5–10 hrs/week
**Started:** [September 2026]

---

## Progress Tracker

### Phase 1 — C# Syntax Speed-Run
- [x] Variables, static typing, `var` vs explicit types
- [x] Value types vs reference types
- [ ] Control flow, methods, method overloading
- [ ] Collections: arrays, `List<T>`, `Dictionary<K,V>`
- [ ] Nullable reference types
- [ ] **Project:** [Expense Tracker (console)](./projects/expense-tracker)

### Phase 2 — OOP and C# Idioms
- [ ] Classes, interfaces, abstract classes, inheritance
- [ ] Properties and auto-properties
- [ ] LINQ
- [ ] Delegates, events, lambdas
- [ ] Generics
- [ ] Exception handling
- [ ] `async`/`await` and `Task`
- [ ] **Project:** [Library/Inventory Management CLI](./projects/library-cli)

### Phase 3 — .NET Ecosystem Fundamentals
- [ ] Solution/project structure, NuGet
- [ ] Dependency Injection
- [ ] Unit testing with xUnit
- [ ] Logging basics

### Phase 4 — ASP.NET Core & Web APIs
- [ ] Minimal APIs vs Controllers
- [ ] Routing, model binding
- [ ] Middleware pipeline
- [ ] DTOs and mapping
- [ ] Validation
- [ ] Swagger/OpenAPI
- [ ] **Project:** [Task/Project Management API](./projects/task-api) — 🔗 [live demo](#)

### Phase 5 — Data Access with EF Core
- [ ] DbContext, migrations, code-first models
- [ ] Relationships
- [ ] LINQ queries through EF Core
- [ ] Real database (Postgres/SQL Server)
- [ ] Task API updated to use persistent storage

### Phase 6 — Auth, Testing, Production Concerns
- [ ] JWT auth, ASP.NET Identity
- [ ] Role/policy-based authorization
- [ ] Integration testing (`WebApplicationFactory`)
- [ ] Structured logging, health checks
- [ ] Task API updated with auth

### Phase 7 — Deployment & Cloud
- [ ] Docker containerization
- [ ] CI/CD with GitHub Actions
- [ ] Deployed to Azure/AWS

### Capstone
- [ ] **Project:** [Capstone — Job Application Tracker / Freelance Invoice Manager](./projects/capstone) — 🔗 [live demo](#)
  - [ ] Full CRUD + auth + roles
  - [ ] File uploads to blob storage
  - [ ] Background jobs
  - [ ] Dockerized + CI/CD
  - [ ] Integration tests
  - [ ] Minimal frontend

---

## Projects

| Project | Description | Status | Link |
|---|---|---|---|
| Expense Tracker | Console app, file-based storage | 🔜 Not started | — |
| Library CLI | OOP + LINQ + repository pattern | 🔜 Not started | — |
| Task API | ASP.NET Core Web API, deployed | 🔜 Not started | — |
| Capstone | Full-stack, auth, deployed, tested | 🔜 Not started | — |

*Status legend: 🔜 Not started · 🚧 In progress · ✅ Complete*

---

## Notes & Learnings

Running log of things that tripped me up or were worth remembering — mainly so future-me doesn't relearn the same lesson twice.

<details>
<summary>Entry I</summary>


</details>

---

## Roadmap

Following a self-built roadmap targeting ASP.NET/backend roles, ~6–8 months at current pace. Full plan: [`ROADMAP.md`](./ROADMAP.md)

---

## Resources Used

- Microsoft Learn
- Official ASP.NET Core docs
- *C# in Depth* by Jon Skeet
