# ABOUT

This website aims to modernize David D. Friedman's current basic webiste. He has enough to worry about, from the threat of grey gu, to the chalenge of pseudo pedantic ameture economists. The primary focus will be on functionality in terms of navigation both for humans and robots.

# DEVELOPMENT SETUP

As this project is mimicking another site, comparing the original is important. Ultimately, CasperJS is used to perform integration testing and reporting of the original site [link](http://daviddfriedman.com/). To use CasperJS, install Node.js which includes NPM (a package manager available at [link](https://nodejs.org/en/), and PhantomJS [link](http://phantomjs.org/).

Unit testing is performed using xUnit.net, which is a .NET unit testing tool [link](https://xunit.github.io/docs/getting-started-dotnet-core.html). To use xUnit, requires dotnet core. Please use the command line implementation as it is more reliable and consistent than the interface of various Visual Studio versions [link](https://github.com/dotnet/core).

At each step of your setup, ensure you have the required dependencies and can call them correctly by checking the version of each component. If you can view the version of CasperJS from the command 'casperjs --version' you likely have correctly installed it. Working on windows I had to add the unziped executable to 'Program Files', then add the 'bin' directory to the path variable of Windows, and finally I had to open a new command prompt.

If you can run integration tests and unit tests, not just version commands, you are all set to run the project. Use your favorite Git-based SCM system to contribute uploads. 

## OPTIONAL DEVELOPMENT SETUP

The project is developed largely on the Windows Subsytem for Linux (WSL). Windows per se has poor support for reliable and common tooling like Emacs and Vim.

For Emacs csharp-mode and xml-mode are useful additions. Many Emcs modes can be installed from https://melpa.org/#/ following instructions on https://www.emacswiki.org/emacs/MELPA. If you use Windows, take care to occlude 'https' in favor of 'http' because there is limited support for it.

# CONTACT

If you need to directly contact the maintainer, please see my github account, jinhale, for details. 
