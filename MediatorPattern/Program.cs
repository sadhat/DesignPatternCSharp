using MediatorPattern;

IMediator mediator = new Dialog();
LoginButton loginButton = new();
loginButton.SetMediator(mediator);

loginButton.OnFireActionPerformed();
