# AzureADWebApi-netcore22
Simple Asp.net core 2.2 web api that is protected by Azure AD and also illustrates role based access

Steps to get this solution to work

1.) Create a AAD App registration and make a note of the ApplicationId
2.) Replace the value of the key "ClientId" in appsettings.json with the ApplicationId retrieved in step 1
3.) Replace the value of the key "TenantId" in appsettings.json with the DirectoryId of the AAD

The client to test this is a sample Javascript client. The client also uses the same AD app registration. 
