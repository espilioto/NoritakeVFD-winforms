# (Name TBD)

This is a simple GUI made to interface with some Noritake serial VFD (tested with [BA63] and [BA66], may work with more)  Customer and Operator Displays.

These displays are great.
Yes, I know that LED and LCD displays exist and draw much less power, are much less fragile and way easier to find/replace but VFDs are special. They have great contrast and can be read easily.
Also you just can't beat that retro/steampunk look!

### Warning

These displays use 5V logic level and 12V for power.
If you try to use them with a USB to UART bridge or a 3.3V microcontroller like I did, it won't work because you need a logic level shifter such as the [MAX3232] in between.

pinouts: [connector] and [jumpers].

### Features
For now the displays can show:

* Static messages
* Scrolling messages 
* Flashing messages

### TODO list

* ~**Finish the new WPF GUI**~ yeah...no. If i ever end up working on this project it will be xplatform fo sho.
* Finish implementing all scrolling modes
* 2x20 or 4x20 display mode option

Maybe:
* ~VU Meter mode~ VFDs can't handle such refresh rates, unfortunately.
* System resources monitor
* System hardware status monitor
* Mail notifier
* RSS reader/(torrent :P) notifier


[BA63]:https://www.dieboldnixdorf.com/en-us/retail/systems/peripherals/customer-operator-displays/ba63
[BA66]:https://www.dieboldnixdorfag.com/en-us/retail/systems/peripherals/customer-operator-displays/ba66
[MAX3232]:http://pdfserv.maximintegrated.com/en/ds/MAX3222-MAX3241.pdf
[connector]:https://i.imgur.com/nl01DJ9.jpg
[jumpers]:https://i.imgur.com/zyeyIpC.jpg


***SouLSLayeR***
