// See https://aka.ms/new-console-template for more information
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;

FirebaseApp.Create(new AppOptions()
{
    Credential = GoogleCredential.FromFile("firebase-config.json"),
});


string tk = "Flutter Firebase IdToken 을 여기에 넣기, GCP IdToken 넣으면 안됨.";
try
{
    var decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(tk);
    string uid = decodedToken.Uid;
    System.Console.WriteLine(decodedToken.Uid);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}