INotifier notifier = new FacebookDecorator(
    new WhatsAppDecorator(
        new Notifier("Geekific")
    )
);
notifier.Send("Like and Subscribe!!!");
