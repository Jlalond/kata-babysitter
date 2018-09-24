# Babysitter Kata

Test and Build instructions
In order to run the tests associated with this solution use the follow command:
'dotnet test src/BabysitterKata/BabysitterKata.Tests'

This will build and run the tests.

**Language** 
C# Specifically .Net core 2.1

** Testing Framework ** 
Nunit -- which actually has useful things like setup unlike previous Xunit

** Build Tools ** 
DotNet Core Command Line Interface [Tools](https://docs.microsoft.com/en-us/dotnet/core/tools/?tabs=netcore2x)

# Personal Note
I don't like using exceptions as a process-flow control model, but for this kata I did. In the requirements it states "NO" later or "NO" earlier, thus I figured an exception is appropriate.
If this was more than a kata and actually production code, I would create my own exceptions, and likely have a framework to aggregate them to give you a full error message, which currently you get the first error returned.
Paired with Jeff for a bit, this was really fun.

## Background
This kata simulates a babysitter working and getting paid for one night.  The rules are pretty straight forward.

The babysitter:
- starts no earlier than 5:00PM
- leaves no later than 4:00AM
- gets paid $12/hour from start-time to bedtime
- gets paid $8/hour from bedtime to midnight
- gets paid $16/hour from midnight to end of job
- gets paid for full hours (no fractional hours)


## Feature
*As a babysitter<br>
In order to get paid for 1 night of work<br>
I want to calculate my nightly charge<br>*
