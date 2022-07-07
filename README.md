# Custom Rich Presence

This is a customisable [rich presence] client for Discord, that enables users to tweak & tune what's displayed as their current activity.

This is a Windows Forms application written in C# using the [.NET Framework](https://docs.microsoft.com/en-us/dotnet/framework/get-started/overview) and the [Discord Game SDK](https://discord.com/developers/docs/game-sdk/sdk-starter-guide).

# Usage

1. Create an application on the [Discord Developer Portal](https://discord.com/developers/applications) with a name that represents what you wish to show on your user profile, and upload a few rich presence assets too.
2. Download and launch the [latest release] of this application, then configure it with the client ID of the Discord application you just created.
3. Tweak the various rich presence parameters until it suits your desires.
4. Click update, then keep the application running in the background.

# History

The 2022 version of this application *(CustomRichPresence)* is a rewrite of the original made in 2018 *(CustomDiscordRPC)*, which can be found on the [master branch](https://github.com/viral32111/CustomDiscordRPC/tree/master).

The original application used the now-deprecated [Discord RPC](https://github.com/discord/discord-rpc) library, and required the DLL for that to be distributed alongside the application's executable. However, this is no longer the case as the rewrite now bundles the DLL within the executable.

Due to the above, and being a former version, the original application is not supported (not like it received any updates over the previous 4 years anyway). The automatic update checker is known to be broken, and I am not even sure if it is able to update rich presence anymore.

# Developing

Opening and contributing to the source code with any development environment should be possible as the user interface has been manually programmed instead of using Visual Studio's drag-and-drop designer.

## License

Copyright (C) 2018-2022 [viral32111](https://viral32111.com).

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as
published by the Free Software Foundation, either version 3 of the
License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program. If not, see https://www.gnu.org/licenses.
