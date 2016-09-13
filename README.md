# OutlookGroupConnectorAPI
Example code how to use Outlook Group Connector as an Azure App Service Api App.

## Installation

Clone or download this repository. 

## Usage

The sample sample API has one endpoint (/api/cards) which will allow a 3rd party to post a inquiry card and process it throught the Outlook Group Connector

In order for the application to fully work the following setup needs to happen:

1- Create a API App Service (https://azure.microsoft.com/en-us/services/app-service/api/)
- Tutorial -> (https://azure.microsoft.com/en-us/documentation/articles/app-service-api-dotnet-get-started/)

2 - Create a "cards" table in MSSQL - see StartupCard.cs in Models

3 - Update webconfig accordingly

4 - Start the process for creating a Outlook Group Connector configuration (https://dev.outlook.com/Connectors)

5 - Add your WebhookURL to the Keys.cs file

## History

None at this time

## Credits

Joshua Drew
Sr Technical Evangelist - Microsoft
@jdruid
Drew5.net

## License

Apache License 

Version 2.0, January 2004 

http://www.apache.org/licenses/ 

## DISCLAIMER:

The sample code described herein is provided on an "as is" basis, without warranty of any kind, to the fullest extent permitted by law. Both Microsoft and I do not warrant or guarantee the individual success developers may have in implementing the sample code on their development platforms or in using their own Web server configurations. 

Microsoft and I do not warrant, guarantee or make any representations regarding the use, results of use, accuracy, timeliness or completeness of any data or information relating to the sample code. Microsoft and I disclaim all warranties, express or implied, and in particular, disclaims all warranties of merchantability, fitness for a particular purpose, and warranties related to the code, or any service or software related thereto. 

Microsoft and I shall not be liable for any direct, indirect or consequential damages or costs of any type arising out of any action taken by you or others related to the sample code.


