using lab8;

Console.WriteLine("Оновлення Товару:");
BaseEntityUpdater productUpdater = new ProductUpdater();
productUpdater.UpdateEntity();

Console.WriteLine("\nОновлення Користувача:");
BaseEntityUpdater userUpdater = new UserUpdater();
userUpdater.UpdateEntity();

Console.WriteLine("\nОновлення Замовлення:");
BaseEntityUpdater orderUpdater = new OrderUpdater();
orderUpdater.UpdateEntity();