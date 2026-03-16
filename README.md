# SimpleAtalaConsole
This is a 64 bit .NET Framework 4.6.2 console app with minimal Atalasoft references set.  

It is meant to be used as a quick starting point for Repros that do not require UI (winforms/wpf) and are not web applications.  

We have a minimal [WebDocumentViewer with WebDocumentThumbnailer](https://github.com/AtalaSupport/SimpleWDVwithWDT) sample app as well as minimal WebCapture (WingScan) apps for web and our AdvanceScanToFile is an excellent minimal Winforms app. For Wpf, we have WpfAnnotations.  


## Licening
This applicaiton requires at minimum any level of DotImage licensing or a valid DotImage eval license on the machine where you are building and running.  

## SDK Dependencies
This app was built based on 11.5.0.10. It targets .NET Framework 4.6.2 and was created in Visual Studio 2022. However, it's fairly backward compatible as distributed. If you start adding references, you can run into issues if you're using an especially outdated version of DotImage. It should also open and run equally well in Visual Studio 2026 without undue modification.  

Regardless, it assumes you ahve installed a valid copy of Atalasoft DotImage in the default location. If you have multiple versions installed, you may want to go to the Project Properties and visit the References tab to adjust the references folder. Defaults point to:  

`C:\Program Files (x86)\Atalasoft\DotImage 11.5\bin\4.6.2\x64`

## Cloning this repository
To use this repro just use:  

```
git clone https://github.com/AtalaSupport/SimpleAtalaConsole.git SimpleAtalaConsole
```

If you've got DotImage 11.5 installed and licensed, it should just build and run.  


## Related documentation
In addition to this README, the Atalasoft documentation set includes the following:  
- API Reference (.chm file) gives the complete Atalasoft WingScan server-side class library for offline use. The latest versions are linked on [Atalasoft's APIs & Developer Guides page](https://www.atalasoft.com/Support/APIs-Dev-Guides).
- In addition, you can also refer to the following Atalasoft resources:
    - [Atalasoft Support](http://www.atalasoft.com/support/)
    - [Atalasoft Knowledgebase](http://www.atalasoft.com/kb2)

## Getting Help for Atalasoft products
Atalasoft regularly updates our support [Knowledgebase](http://www.atalasoft.com/kb2) with the latest information about our products. To access some resources, you must have a valid Support Agreement with an authorized Atalasoft Reseller/Partner or with Atalasoft directly. Use the tools that Atalasoft provides for researching and identifying issues. 

Customers with an active evaluation, or those with active support / maintenance may [create a support case](https://www.atalasoft.com/Support/my-portal/Cases/Create-Case) 24/7, or call in to support ([+1 949 236-6510](tel:19492366510) ) during our normal support hours (Monday - Friday 8:00am to 5:00PM Eastern (New York) time).  

Customers who are unable to create a case or call in may [email our Sales Team](email:sales@atalasoft.com).  

