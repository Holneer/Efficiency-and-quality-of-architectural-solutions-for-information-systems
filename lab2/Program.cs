using lab2;

SocialNetworkCreator facebookCreator = new FacebookCreator();
facebookCreator.PublishMessage("user_login", "user_password", "Привіт, Facebook!");

SocialNetworkCreator linkedInCreator = new LinkedInCreator();
linkedInCreator.PublishMessage("user_email@example.com", "user_password", "Привіт, LinkedIn!");