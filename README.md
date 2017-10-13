# BraveHaxvius

Brave Haxvius is an educational repository for teaching the network internals of an example mobile app.

# High Level Overview

To learn how the app functions, you need to understand the client-server communication. For every action, the client sends a single data object to the server, and the server replies with a single data object. In this example, the server will not talk to the client randomly - it only replies when the client talks to it. The app on your phone is the client, and the server is sitting somewhere hosted by the game company.

# Network sniffing

The first step to reverse engineering any network protocol is to sniff packets. This can be done with a myriad of tools, such as Wireshark, Fiddler, mitm, etc. Wireshark is generally the best at capturing all data, and supports plugins you can write to help streamline the decode process. In this case, the mobile app we are looking at is doing primarily HTTPS - I prefer Fiddler for HTTP sniffing. There are plenty of guides on how to use these tools online.

One note - to deter these tools, many app developers are using HTTPS certificate pinning, effectively to prevent your Fiddler certificate from being able to decode the packets correctly. That's a guide for another time - as this example app doesn't use it on iPhone.

# Encryption and Compression

So, assuming you've fired up Fiddler and found a sample data packet that this app uses, you'll notice you cannot understand the data. As a means to thwart reverse engineering, developers encrypt+compress packets over the wire. Decoding this is generally the most technically challenging part of this series. I'm going to cheat and provide you the methods upfront though.
The packet strings often end in an "=", that's generally a surefire identification method for BASE64 encoding. Decoding that is trivial.
Now, you have a bunch of random bytes - this app uses AES ECB encryption with PKCS7 padding. It requires a key, which can be found in the app binary file. TBD on how to dump these. Python IDA scripts are helpful for scaling, and app updates. Knowing the encryption method, and the key, makes decryption trivial. After decrypting these bytes, you should get a JSON string.

# Injection

Injection is extremely simple. Once you have figured out how to watch and decode packets, you can see all the data makes up a MissionStart and a MissionEnd request. During MissionEnd, injection is possible. One might quickly assume, "oh, add an item as a regular drop!" This method doesn't work as the server validates dropped loot. After further investigation, you can find all the other options to acquire items after battle - such as stealing an item, finding items in those shiny areas during explorations, or even finding items in chests. All of these are validated though. So where else can you get items? Items trusted! You know those extra low-tier items you get after battle occasional? If you tell the server you get something from trust mastery, the server blindly accepts them!

# Lots more to come.

# Feel like buying me a cup of coffee?

[![paypal](https://www.paypalobjects.com/en_US/i/btn/btn_donate_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=RZCNSSMSHTCE6)

# Legal stuff

MIT License

*BraveHaxvius and Shalzuth aren't endorsed by SQUARE ENIX CO., LTD. or gumi Inc. and doesn’t reflect the views or opinions of SQUARE ENIX CO., LTD. or gumi Inc. or anyone officially involved in producing or managing SQUARE ENIX CO., LTD. or gumi Inc. Game content and materials are trademarks and copyrights of SQUARE ENIX CO., LTD. or gumi Inc.*

