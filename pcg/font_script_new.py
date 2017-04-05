#!/C:\inetpub\wwwroot\New folder
import fontforge
font = fontforge.font() # create a new font 

x=1

while (x<89):
	true_x = 63+x
	glyph = font.createMappedChar(true_x)
	nomo = "File" + str(x).zfill(3)+ ".svg"
	glyph.importOutlines(nomo)
	x+=1

font.generate("foobar.ttf") # truetype