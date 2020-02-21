#!/var/www/html
import fontforge
font = fontforge.font() # create a new font 

for x in range(89):
	glyph = font.createMappedChar(63+x)
	nomo = "output\File" + str(x).zfill(3)+ ".svg"
	glyph.importOutlines(nomo)

font.generate("foobar.ttf") # truetype
