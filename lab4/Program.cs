using lab4;

INotification emailNotification = new EmailNotification("admin@example.com");
emailNotification.Send("Важливе повідомлення", "Ваш обліковий запис буде заблоковано через 24 години.");

SlackService slackService = new SlackService("user_login", "api_key");
INotification slackNotification = new SlackNotificationAdapter(slackService, "general");
slackNotification.Send("Важливе повідомлення", "Система буде оновлена сьогодні о 10:00.");

SmsService smsService = new SmsService();
INotification smsNotification = new SmsNotificationAdapter(smsService, "+123456789", "Адміністрація");
smsNotification.Send("Термінове повідомлення", "Зателефонуйте до служби підтримки.");