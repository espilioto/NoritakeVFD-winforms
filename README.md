# (Name TBD)

This is a simple GUI made to interface with some Noritake serial VFD (tested with [BA63] and [BA66], may work with more)  Customer and Operator Displays.

These displays are great.
Yes, I know that LED and LCD displays exist and draw much less power, are much less fragile and way easier to find/replace but VFDs are special. They have great contrast and can be read easily.
Also you just can't beat that retro/steampunk look!

###Warning

These displays use 5V logic level and 12V for power.
If you try to use them with a USB to UART bridge or a 3.3V microcontroller like I did, it won't work because you need a logic level shifter such as the [MAX3232] in between.

pinouts: [connector] and [jumpers].

###Features
For now the displays can show:

* Static messages
* Scrolling messages 
* Flashing messages

###TODO list

* **Finish the new WPF GUI**
* Finish implementing all scrolling modes
* 2*20 or 4x20 display mode option

Maybe:
* VU Meter mode
* System resources monitor
* System hardware status monitor
* Mail notifier
* RSS reader/(torrent :P) notifier


[BA63]:http://www.wincor-nixdorf.com/internet/site_EN/EN/Products/Hardware/Retail/Peripherals/CustomOperDisplays/BA63/ba63_node.html
[BA66]:http://www.wincor-nixdorf.com/internet/site_EN/EN/Products/Hardware/Retail/Peripherals/CustomOperDisplays/BA66/ba66_node.html
[MAX3232]:http://pdfserv.maximintegrated.com/en/ds/MAX3222-MAX3241.pdf
[connector]:https://i.imgur.com/nl01DJ9.jpg
[jumpers]:https://i.imgur.com/zyeyIpC.jpg


***SouLSLayeR***
