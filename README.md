# elite-app
Elite Dangerous data recording tool for trade routes &amp; bounty hunting sites. 
Just an exercise in getting back into some coding.
Second attempt after first project total breakdown... hence github!

0.1 notes

Whats it for?
-------------
Uses elite dangerous database resources to populate UI widgets, providing quick data recording of trade routes & bounty 
hunting zones. Data collected can be stored online for shared access by groups of CMDRs. May turn out to be utterly useless,
just fancied making something for other than academic purposes!


Working features
----------------
= Uses stations.json & systems.json files retrieved from Elite Dangerous database (eddb.io) to populate comboboxes. 
  Presently retrieved manually, loading into app locally at startup.

= Basic UI layout established.

To do
-----
= Decide on means of saving trade & bounty data. Simple CSV file? Database?

= Format displaying of recorded data in "Trade data" and "Bounty data" tabs

= Enable retrieval of updated json files (Options menu)

= Local user settings XML for assigning CMDR name, data file URLs etc. (Options) 


Bugs
----
= Slow to display Bounty tool tabbed pane. Initialised in Load_Form method.
