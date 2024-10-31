using lab7;

decimal orderAmount = 130;

DeliveryContext context = new DeliveryContext(new PickupDelivery());
Console.WriteLine($"Вартість доставки: {context.ExecuteStrategy(orderAmount)}\n");

context.SetDeliveryStrategy(new ExternalDelivery());
Console.WriteLine($"Вартість доставки: {context.ExecuteStrategy(orderAmount)}\n");

context.SetDeliveryStrategy(new InternalDelivery());
Console.WriteLine($"Вартість доставки: {context.ExecuteStrategy(orderAmount)}\n");