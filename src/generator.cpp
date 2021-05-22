#include "generator.h"

//destructor
generator::~generator()
{

}

//constructor
generator::generator()
{

}

void generator::generate(grapheme& g) const
{
  generate(g, 5, 2);
}

void generator::printmap(grapheme& g, int n)
{
char filename[sizeof "File100.bmp"];
BMP myImage;
int size_x = g.ncols();
int size_y = g.nrows();
myImage.SetSize(size_x,size_y);
myImage.SetBitDepth(32);
for(int yIndex=0; yIndex<size_y; yIndex++){
	for(int xIndex=0; xIndex<size_x; xIndex++){
		switch(g.get(yIndex,xIndex)){
			case false:
 				myImage(xIndex,yIndex)->Red   = 0;
				myImage(xIndex,yIndex)->Green = 0;
				myImage(xIndex,yIndex)->Blue  = 0;
				myImage(xIndex,yIndex)->Alpha = 0; break;
		}
	}
}
sprintf(filename,"File%03d.bmp",n);
myImage.WriteToFile(filename);
}

void generator::generate(grapheme& g, int r1_cutoff, int r2_cutoff) const
{
  /*
  if count_r1 >= r1_cutoff || count_r2 <= r2_cutoff
  then make R true!
  ░░░░2
  ░▓▓1░
  ░▓R▓░
  ░▓▓▓░
  ░░░░░
  */
  int xi, yi, ii, jj;

  int size_x = g.ncols();
  int size_y = g.nrows();

  grapheme g2(size_y,size_x);

	for(yi=1; yi<size_y-1; yi++)
	for(xi=1; xi<size_x-1; xi++)
 	{
 		int adjcount_r1 = 0,
 		    adjcount_r2 = 0;

 		for(ii=-1; ii<=1; ii++)
		for(jj=-1; jj<=1; jj++)
 		{
 			if(g.get(yi+ii,xi+jj))
 				adjcount_r1++;
 		}
 		for(ii=yi-2; ii<=yi+2; ii++)
 		for(jj=xi-2; jj<=xi+2; jj++)
 		{
 			if(abs(ii-yi)==2 && abs(jj-xi)==2)
 				continue;
 			if(ii<0 || jj<0 || ii>=size_y || jj>=size_x)
 				continue;
 			if(g.get(ii,jj))
 				adjcount_r2++;
 		}
 		if(adjcount_r1 >= r1_cutoff || adjcount_r2 <= r2_cutoff)
 			g2.set(yi,xi,true);
 		else
 			g2.set(yi,xi,false);
 	}
 	for(yi=1; yi<size_y-1; yi++)
 	for(xi=1; xi<size_x-1; xi++)
 		g.set(yi,xi, g2.get(yi,xi));
}
