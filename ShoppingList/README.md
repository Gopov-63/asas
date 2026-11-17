# ShoppingList – ASP.NET Core MVC (.NET 8)

Уеб приложение за пазаруване според Упражнение 2.

## Как да стартирате

1. Отворете папката `ShoppingList` във **Visual Studio 2022**.
2. Възстановете NuGet пакетите (дясно копче върху solution → Restore NuGet Packages).
3. Отворете **Package Manager Console** и изпълнете:
   ```
   Add-Migration CreateDb
   Update-Database
   ```
4. Стартирайте с **F5** (или Ctrl+F5).
5. Регистрирайте потребител (без нужда от email confirmation).
6. Отидете на **Products** → Create New.

## Какво е включено

- Individual Accounts (Identity)
- Connection string с `Encrypt=true;TrustServerCertificate=true`
- Облекчени изисквания към паролите + без confirmation
- Entities: `Product` и `ProductNote` (едно към много)
- Пълен CRUD за Products
- Index с Bootstrap Cards
- Client-side валидация

## Важно

- Изисква се **SQL Server LocalDB** или **SQL Server Express**.
- Ако миграциите не работят, в `ApplicationDbContext` разкоментирайте `Database.EnsureCreated();`
