# ABOUT

This website aims to modernize David D. Friedman's current basic
[webiste](http://daviddfriedman.com/). He has enough to worry about,
from the threat of grey gu, to the chalenge of pseudo pedantic ameture
economists. The primary focus will be on functionality in terms of
navigation both for humans and robots.

# DEVELOPMENT SETUP

As this project is mimicking another site, comparing the original is
important. Ultimately, CasperJS is used to perform integration testing
and reporting of the original [site](http://daviddfriedman.com/). To
use CasperJS, install Node.js which includes NPM (a package manager
available at [nodejs.org](https://nodejs.org/en/), and
[PhantomJS](http://phantomjs.org/).

Unit testing is performed using xUnit.net, which is a [.NET unit
testing
tool](https://xunit.github.io/docs/getting-started-dotnet-core.html). To
use xUnit, requires dotnet core. Please use the [command line
implementation](https://github.com/dotnet/core) of .NET Core as it is
more reliable and consistent than the interface of various Visual
Studio versions.

At each step of your setup, ensure you have the required dependencies
and can call them correctly by checking the version of each
component. If you can view the version of CasperJS from the command
'casperjs --version' you likely have correctly installed it. Working
on windows I had to add the unziped executable to 'Program Files',
then add the 'bin' directory to the path variable of Windows, and
finally I had to open a new command prompt.

If you can run integration tests and unit tests, not just version
commands, you are all set to run the project. Use your favorite
Git-based SCM system to contribute uploads.

## SSL

The SSL password must be private and never exposed to the public
especially via github.  Follow
[instructions](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?tabs=visual-studio)
to store the SSL password.  Create your own self-signed certificate as
your OS allows.  SSL is required. 

## OPTIONAL DEVELOPMENT SETUP

The project is developed largely on the Windows Subsytem for Linux
(WSL). Windows per se has poor support for reliable and common tooling
like Emacs and Vim.

For Emacs csharp-mode and xml-mode are useful additions. Many Emacs
modes can be installed from https://melpa.org/#/ following
instructions on https://www.emacswiki.org/emacs/MELPA. If you use
Windows, take care to occlude 'https' in favor of 'http' because there
is limited support for it.

# HOW TO RUN INTEGRATION TESTS

## SERVE THE WEBSITE LOCALLY:
1. Navigate to the correct directory: `$ cd david_d_friedman`.
2. Start the .NET Core command-line server `$ dotnet run`.
3. Optionally verify the server is running by browsing `localhost:5001`.

NOTE: If you have problems first check that you are not in the project
or unit testing directory.

## RUN THE TESTS
1. Navigate to the correct directory.
1.1. Live reporting: `$ cd live_reporting`.
2. Run integration tests and reports.
2.1. Examine the links in a report: `$ casperjs.exe link_report.js`
2.2. For non Windows systems, there are [alternative executable commands](http://docs.casperjs.org/en/latest/quickstart.html#a-minimal-scraping-script).

# HOW TO RUN UNIT TESTS

1. Navigate to the correct directory: `$ cd david_d_friedman.tests`.
2. Execute the test: `dotnet test`.

NOTE: Attempting to run `dotnet test` in the solution directory will
attempt to run tests for both projects. This will give an error
indicating that one project is missing tests, then testing proceeds.

# CONTACT

If you need to directly contact the maintainer, please see the github
account, jinhale, for details.
