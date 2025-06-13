Microsoft Docs:
https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-10/sdk#more-consistent-command-order

# Commands
| New noun-first form     | Alias for               |
|-------------------------|-------------------------|
| dotnet package add      | dotnet add package      |
| dotnet package list     | dotnet list package     |
| dotnet package remove   | dotnet remove package   |
| dotnet reference add    | dotnet add reference    |
| dotnet reference list   | dotnet list reference   |
| dotnet reference remove | dotnet remove reference |


# Native shell tab-completion scripts

```
> dotnet completions
Required command was not provided.

Description:
  Commands for generating and registering completions for supported shells

Usage:
  dotnet completions [command] [options]

Options:
  -?, -h, --help  Show command line help.

Unhandled exception: 
The shell application 'zsh' is not supported. 
The following shells are supported by this application: bash, pwsh, fish, zsh, nushell
```
