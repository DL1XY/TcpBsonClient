# Required

* Kernys.Bson
* Unity3D 4.x (Free or Pro)

# HowTo

* Add Kernys.Bson to your Unity3D project
* Add the files to your Unity3D project 
* Change PORT and SERVER_ADDR in BSONClient.cs according your requirements
* Create a class which implements the IObserver interface, see CmdManager for a way to handle incoming/outgoing commands
* Create client commands (= commands which are handled by the client) by inherit from BaseClientCmd (see ClientCmdMessageException)
* Create server commands (= commands which are handled by the server) by inherit from BaseServerCmd (see ServerCmdLogout)
* Create a BSONClient object in Unity3D as usual
